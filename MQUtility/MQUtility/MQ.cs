using System;
using System.Messaging;

namespace MQUtility
{
    public class MQ : IMQ
    {
        public string Path { get; private set; } = string.Empty;

        private readonly object _lockObj = new object();

        private MessageQueue _mq = null;
        private Action<object> _action = null;
        private Func<object, bool> _func = null;

        public MQ(string name)
        {
            Path = @".\Private$\" + name.ToLower();
            CreateQueue(Path);
        }

        public virtual void RegisterReceive(Action<object> action)
        {
            if (_action == null)
            {
                _action = action;
                //  註冊 receive 事件
                _mq.ReceiveCompleted += new ReceiveCompletedEventHandler(RcvCompleted);
            }

            //  開始接收
            _mq.BeginReceive();
        }

        public virtual void RegisterPeek(Func<object, bool> func)
        {
            if (_action == null)
            {
                _func = func;

                //  註冊 receive 事件
                _mq.PeekCompleted += new PeekCompletedEventHandler(PeekCompleted);
            }

            //  開始接收
            _mq.BeginPeek();
        }

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

        public virtual bool IsExists()
        {
            return MessageQueue.Exists(Path);
        }

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

        /// <summary>
        ///     接收完成後處理的動作
        /// </summary>
        protected virtual void RcvCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            lock (_lockObj)
            {
                //  委派執行的動作
                _action(e.Message.Body);

                //  繼續開始接收
                _mq.BeginReceive();
            }
        }

        /// <summary>
        ///     接收完成後處理的動作
        /// </summary>
        protected virtual void PeekCompleted(object sender, PeekCompletedEventArgs e)
        {
            lock (_lockObj)
            {
                //  委派執行的動作
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

        /// <summary>
        ///     建立佇列
        /// </summary>
        public virtual void CreateQueue(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new Exception($"MSMQ path is empty");

            //  檢查佇列是否存在
            if (!IsExists())
            {
                _mq = null;
                MessageQueue.Create(path);
            }

            if (_mq == null)
            {
                _mq = new MessageQueue(path);
                _mq.DefaultPropertiesToSend.Recoverable = true; //Default Forever Save
                _mq.Formatter = new BinaryMessageFormatter();
            }
        }

        public virtual void DeleteQueue()
        {
            // Determine whether the queue exists.
            if (MessageQueue.Exists(Path))
            {
                try
                {
                    // Delete the queue.
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
