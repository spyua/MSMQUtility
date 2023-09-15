using System;

namespace MQUtility
{
    public interface IMQ
    {
        /// <summary>
        ///     訊息佇列的路徑
        /// </summary>
        string Path { get; }

        /// <summary>
        ///     註冊接收事件
        /// </summary>
        /// <param name="action">在接收後執行的動作</param>
        void RegisterReceive(Action<object> action);

        /// <summary>
        ///     註冊預覽事件
        /// </summary>
        /// <param name="func">在預覽後執行的函數</param>
        void RegisterPeek(Func<object, bool> func);

        /// <summary>
        ///     發送訊息
        /// </summary>
        /// <param name="msg">要發送的訊息內容</param>
        void SendMsg(object msg);

        /// <summary>
        ///     從佇列中移除第一條資料
        /// </summary>
        void RemoveFirstData();

        /// <summary>
        ///     清空佇列中的所有資料
        /// </summary>
        void ClearData();

        /// <summary>
        ///     檢查訊息佇列路徑是否存在
        /// </summary>
        /// <returns>true：存在；false：不存在</returns>
        bool IsExists();

        /// <summary>
        ///     從佇列中取得資料的數量
        /// </summary>
        /// <returns>佇列中的資料數量</returns>
        long CountData();

        /// <summary>
        ///     嘗試預覽佇列中的第一條資料，但不移除它
        /// </summary>
        /// <returns>佇列中的第一條資料</returns>
        object PeekMsg();

        /// <summary>
        ///     從佇列中取出並移除第一條資料
        /// </summary>
        /// <returns>佇列中的第一條資料</returns>
        object ReceiveMsg();

        /// <summary>
        /// 刪除訊息佇列
        /// </summary>
        void DeleteQueue();
    }
}
