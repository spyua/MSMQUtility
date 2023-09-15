using System;
using System.Messaging;

namespace MQUtility
{
    public class MQ : IMQ
    {
        // 訊息佇列的路徑
        public string Path { get; private set; } = string.Empty;

        // 鎖物件，用於同步
        private readonly object _lockObj = new object();

        // 訊息佇列物件
        private MessageQueue _mq = null;
        // 接收訊息的回呼方法
        private Action<object> _action = null;
        // 預覽訊息的回呼方法
        private Func<object, bool> _func = null;

        // 建構子，初始化佇列
        public MQ(string name)
        {
            Path = @".\Private$\" + name.ToLower();
            CreateQueue(Path);
        }

        // 註冊一個接收訊息的事件
        public virtual void RegisterReceive(Action<object> action)
        {
            if (_action == null)
            {
                _action = action;
                _mq.ReceiveCompleted += new ReceiveCompletedEventHandler(RcvCompleted);
            }
            _mq.BeginReceive();
        }

        // 註冊一個預覽訊息的事件
        public virtual void RegisterPeek(Func<object, bool> func)
        {
            if (_action == null)
            {
                _func = func;
                _mq.PeekCompleted += new PeekCompletedEventHandler(PeekCompleted);
            }
            _mq.BeginPeek();
        }

        // 發送一條訊息到佇列中
        public virtual void SendMsg(object msg)
        {
            lock (_lockObj)
            {
                try
                {
                    _mq.Send(msg);
                }
                catch
                {
                    throw;
                }
            }
        }

        // 移除佇列中的第一條訊息
        public virtual void RemoveFirstData()
        {
            try
            {
                _mq.Receive();
            }
            catch
            {
                throw;
            }
        }

        // 清空佇列中的所有訊息
        public virtual void ClearData()
        {
            lock (_lockObj)
            {
                try
                {
                    _mq.Purge();
                }
                catch
                {
                    throw;
                }
            }
        }

        // 檢查佇列是否存在
        public virtual bool IsExists()
        {
            return MessageQueue.Exists(Path);
        }

        // 取得佇列中的訊息數量
        public virtual long CountData()
        {
            try
            {
                var enumerator = _mq.GetMessageEnumerator2();
                var count = 0L;

                while (enumerator.MoveNext())
                {
                    count++;
                }

                return count;
            }
            catch
            {
                throw;
            }
        }

        // 從佇列中接收並移除第一條訊息
        public virtual object ReceiveMsg()
        {
            try
            {
                var msg = _mq.Receive();
                return msg.Body;
            }
            catch
            {
                throw;
            }
            finally
            {
                _mq.Close();
            }
        }

        // 從佇列中預覽第一條訊息，但不移除它
        public virtual object PeekMsg()
        {
            try
            {
                var msg = _mq.Peek();
                return msg.Body;
            }
            catch
            {
                throw;
            }
            finally
            {
                _mq.Close();
            }
        }

        // 接收完訊息後的回呼方法
        protected virtual void RcvCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            lock (_lockObj)
            {
                _action(e.Message.Body);
                _mq.BeginReceive();
            }
        }

        // 預覽完訊息後的回呼方法
        protected virtual void PeekCompleted(object sender, PeekCompletedEventArgs e)
        {
            lock (_lockObj)
            {
                if (_func.Invoke(e.Message.Body))
                {
                    _mq.BeginReceive();
                }
                else
                {
                    _mq.BeginPeek();
                }
            }
        }

        // 創建佇列
        public virtual void CreateQueue(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new Exception($"MSMQ path is empty");

            if (!IsExists())
            {
                _mq = null;
                MessageQueue.Create(path);
            }

            if (_mq == null)
            {
                _mq = new MessageQueue(path);
                _mq.DefaultPropertiesToSend.Recoverable = true;
                _mq.Formatter = new BinaryMessageFormatter();
            }
        }

        // 刪除佇列
        public virtual void DeleteQueue()
        {
            if (MessageQueue.Exists(Path))
            {
                try
                {
                    MessageQueue.Delete(Path);
                }
                catch (MessageQueueException e)
                {
                    throw e;
                }
            }
        }
    }
}
