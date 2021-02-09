using System;
using System.Collections.Concurrent;

namespace MQUtility
{
    public class MQPool : IMQPool
    {
        public ConcurrentDictionary<string, IMQ> DicMQPool { get; private set; } = null;

        public MQPool(params string[] names)
        {
            DicMQPool = new ConcurrentDictionary<string, IMQ>();
            AddMQPool(names);
        }

        public MQPool AddTargetMQ(params string[] names)
        {
            AddMQPool(names);
            return this;
        }

        public virtual IMQ GetMQ(string name)
        {
            return DicMQPool[name];
        }

        public virtual void RegisterRcv(string name, Action<object> action)
        {
            DicMQPool[name].RegisterReceive(action);
        }
        public virtual void RegisterPeek(string name, Func<object, bool> func)
        {
            DicMQPool[name].RegisterPeek(func);
        }

        public virtual void SendMsg(string name, object msg)
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

        public virtual T ReceiveMsg<T>(string name)
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
        public virtual T PeekMsg<T>(string name)
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
        public virtual long GetDataCont(string name)
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
        public virtual void RemoveFirstData(string name)
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
        public virtual void ClearData(string name)
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
        public virtual void RemoveQueue(string name)
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
        private void AddMQPool(params string[] names)
        {
            foreach (var name in names)
                if (!DicMQPool.ContainsKey(name))
                    DicMQPool.TryAdd(name, new MQ(name));
        }

       
    }
}
