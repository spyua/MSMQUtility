using System;

namespace MQUtility
{
    public interface IMQPool
    {

        void RegisterRcv(string name, Action<object> action);
  
        void RegisterPeek(string name, Func<object, bool> func);
     
        void SendMsg(string name, object msg);
 
        long GetDataCont(string name);
 
        T PeekMsg<T>(string name);

        T ReceiveMsg<T>(string name);
    
        void RemoveFirstData(string name);

        void ClearData(string name);
    }
}
