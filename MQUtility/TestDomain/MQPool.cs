using MQUtility;
using System;
using System.Collections.Generic;

namespace TestDomain
{
    public class MQPool : IMQPool
    {
        public Dictionary<string, IMQ> DicMQ { get; private set; } = null;

        public MQPool() 
        {
            DicMQ = new Dictionary<string, IMQ>();
        }

        public void InitRcv(string name, Action<object> action)
        {
            //_log.Info($"建立 MQ Rcv, name={name}", LogStyle.Flow);

            GetMQ(name).Receive(action);
        }

        public void InitPeek(string name, Func<object, bool> func)
        {
            //_log.Info($"建立 MQ Peek, name={name}", LogStyle.Flow);

            GetMQ(name).Peek(func);
        }

        public void Send(string name, object msg)
        {
            //_log.Info($"MQ 傳送訊息至 {name}", LogStyle.Flow);

            GetMQ(name).Send(msg);
        }

        public long GetCount(string name)
        {
            //_log.Info($"取 MQ({name}) 數量", LogStyle.Flow);

            var count = GetMQ(name).Count();

            //_log.Debug($"取得數量={count}");

            return count;
        }

        public T PeekData<T>(string name)
        {
            //_log.Info($"Peek MQ({name}) 訊息", LogStyle.Flow);

            var obj = GetMQ(name).PeekMsg();

            return (T)obj;
        }

        public void RemoveFirst(string name)
        {
            //_log.Info($"移除 MQ({name}) 中的第一筆訊息", LogStyle.Flow);

            GetMQ(name).RemoveFirst();
        }



        /// <summary>
        ///     由字典取出 MQ
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        private IMQ GetMQ(string name)
        {
            //  若不在字典內就新增該 MQ
            if (!DicMQ.ContainsKey(name))
                DicMQ.Add(name, new MQ(name));

            return DicMQ[name];
        }
    }
}
