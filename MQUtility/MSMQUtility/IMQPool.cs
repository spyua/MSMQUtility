using System;

namespace MQUtility
{
    /// <summary>
    /// 定義一個訊息佇列池的接口，它允許用戶註冊、發送和接收訊息。
    /// </summary>
    public interface IMQPool
    {
        /// <summary>
        /// 註冊一個動作以接收指定名稱的訊息。
        /// </summary>
        /// <param name="name">佇列的名稱。</param>
        /// <param name="action">當訊息到達時需要執行的動作。</param>
        void RegisterRcv(string name, Action<object> action);

        /// <summary>
        /// 註冊一個函數以預覽指定名稱的訊息，而不真正消耗它。
        /// </summary>
        /// <param name="name">佇列的名稱。</param>
        /// <param name="func">評估訊息是否滿足某些條件的函數。</param>
        void RegisterPeek(string name, Func<object, bool> func);

        /// <summary>
        /// 向指定名稱的佇列發送訊息。
        /// </summary>
        /// <param name="name">佇列的名稱。</param>
        /// <param name="msg">要發送的訊息物件。</param>
        void SendMsg(string name, object msg);

        /// <summary>
        /// 取得指定名稱佇列中的訊息數量。
        /// </summary>
        /// <param name="name">佇列的名稱。</param>
        /// <returns>該佇列中的訊息數量。</returns>
        long GetDataCont(string name);

        /// <summary>
        /// 預覽指定名稱的佇列中的第一條訊息，但不從佇列中移除它。
        /// </summary>
        /// <typeparam name="T">訊息的資料類型。</typeparam>
        /// <param name="name">佇列的名稱。</param>
        /// <returns>該佇列中的第一條訊息。</returns>
        T PeekMsg<T>(string name);

        /// <summary>
        /// 從指定名稱的佇列中接收（並移除）第一條訊息。
        /// </summary>
        /// <typeparam name="T">訊息的資料類型。</typeparam>
        /// <param name="name">佇列的名稱。</param>
        /// <returns>該佇列中的第一條訊息。</returns>
        T ReceiveMsg<T>(string name);

        /// <summary>
        /// 從指定名稱的佇列中移除第一條訊息。
        /// </summary>
        /// <param name="name">佇列的名稱。</param>
        void RemoveFirstData(string name);

        /// <summary>
        /// 清空指定名稱的佇列中的所有訊息。
        /// </summary>
        /// <param name="name">佇列的名稱。</param>
        void ClearData(string name);
    }
}
