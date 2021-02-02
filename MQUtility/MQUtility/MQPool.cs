using System;
using System.Collections.Concurrent;

namespace MQUtility
{
    public class MQPool : IMQPool
    {
        public ConcurrentDictionary<string, IMQ> DicMQPool { get; private set; } = null;

        public MQPool(string name)
        {
            DicMQPool = new ConcurrentDictionary<string, IMQ>();
            AddMQPool(name);
        }

        public MQPool AddObjectMQ(string name)
        {
            AddMQPool(name);
            return this;
        }

        public IMQ GetMQ(string name)
        {
            return DicMQPool[name];
        }

        public void RegisterRcv(string name, Action<object> action)
        {
            DicMQPool[name].RegisterReceive(action);
        }
        public void RegisterPeek(string name, Func<object, bool> func)
        {
            DicMQPool[name].RegisterPeek(func);
        }

        public void SendMsg(string name, object msg)
        {
            try
            {
                DicMQPool[name].SendMsg(msg);
            }
            catch
            {
                throw;
            }
           
            
        }

        public T ReceiveMsg<T>(string name)
        {
            try
            {
                var obj = DicMQPool[name].ReceiveMsg();
                return (T)obj;
            }
            catch
            {
                throw;
            }
               
           
          
        }
        public T PeekMsg<T>(string name)
        {
            try
            {
                var obj = DicMQPool[name].PeekMsg();
                return (T)obj;
            }
            catch
            {
                throw;
            }
         
        }
        public long GetDataCont(string name)
        {
            try
            {
                var count = DicMQPool[name].CountData();
                return count;
            }
            catch
            {
                throw;
            }
           
        }
        public void RemoveFirstData(string name)
        {
            try
            {
                DicMQPool[name].RemoveFirstData();
            }
            catch
            {
                throw;
            }
        
        }
        public void ClearData(string name)
        {

            try
            {
                DicMQPool[name].ClearData();
            }
            catch
            {
                throw;
            }
     
        }
        public void RemoveQueue(string name)
        {
            try
            {
                IMQ msg;
                DicMQPool[name].DeleteQueue();
                DicMQPool.TryRemove(name, out msg);
            }
            catch
            {
                throw;
            }
          
        }
        private void AddMQPool(string name)
        {
            if (!DicMQPool.ContainsKey(name))
                DicMQPool.TryAdd(name, new MQ(name));
        }

       
    }
}
