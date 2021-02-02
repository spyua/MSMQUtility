using System;

namespace MQUtility
{
    public interface IMQPool
    {

        /// <summary>
        ///     建立 MQ 接收
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        /// <param name="action"> 接收完成後要處理的動作 </param>
        void RegisterRcv(string name, Action<object> action);

        /// <summary>
        ///     建立 MQ 接收
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        /// <param name="func"> 接收完成後要處理的動作 </param>
        void RegisterPeek(string name, Func<object, bool> func);

        /// <summary>
        ///     發送 MQ
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        /// <param name="msg"> 訊息物件 </param>
        void Send(string name, object msg);

        /// <summary>
        ///     取得 MQ 的訊息數
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        /// <returns> 訊息數 </returns>
        long GetCount(string name);

        /// <summary>
        ///     取得 peek 的訊息內容
        /// </summary>
        /// <typeparam name="T"> 注入型別，回傳值的型別 </typeparam>
        /// <param name="name"> MQ 名稱 </param>
        /// <returns> 訊息內容 </returns>
        T Peek<T>(string name);

        /// <summary>
        ///     移除 MQ 中的第一筆訊息
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        void RemoveFirst(string name);

        /// <summary>
        ///     移除 MQ 所有訊息
        /// </summary>
        /// <param name="name"> MQ 名稱 </param>
        void Clear(string name);
    }
}
