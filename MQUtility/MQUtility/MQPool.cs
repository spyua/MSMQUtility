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
            DicMQPool[name].Receive(action);
        }
        public void RegisterPeek(string name, Func<object, bool> func)
        {
            DicMQPool[name].Peek(func);
        }

        public void Send(string name, object msg)
        {
            this.DicMQPool[name].Send(msg);
        }
        public T Peek<T>(string name)
        {
            var obj = this.DicMQPool[name].PeekMsg();
            return (T)obj;
        }

        public long GetCount(string name)
        {
            var count = this.DicMQPool[name].Count();
            return count;
        }
        public void RemoveFirst(string name)
        {
            this.DicMQPool[name].RemoveFirst();
        }

        public void Clear(string name)
        {
            this.DicMQPool[name].Clear();
        }
        private void AddMQPool(string name)
        {
        
            if (!DicMQPool.ContainsKey(name))
                DicMQPool.TryAdd(name, new MQ(name));
        }

      
    }
}
