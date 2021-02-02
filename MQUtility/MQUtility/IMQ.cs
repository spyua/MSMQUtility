using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQUtility
{
    public interface IMQ
    {
        /// <summary>
        ///     佇列路徑
        /// </summary>
        string Path { get; }

        /// <summary>
        ///     建立接收
        /// </summary>
        /// <param name="action"> 接收完成後要處理的動作 </param>
        void Receive(Action<object> action);

        /// <summary>
        ///     建立接收
        /// </summary>
        /// <param name="func"> 接收完成後要處理的動作 </param>
        void Peek(Func<object, bool> func);

        /// <summary>
        ///     發送
        /// </summary>
        /// <param name="msg"> 發送的訊息物件 </param>
        void Send(object msg);

        /// <summary>
        ///     將第一筆訊息從佇列中移除
        /// </summary>
        void RemoveFirst();

        /// <summary>
        ///     清空佇列
        /// </summary>
        void Clear();

        /// <summary>
        ///     檢查佇列是否存在
        /// </summary>
        /// <returns> true：存在，false：不存在 </returns>
        bool IsExists();

        /// <summary>
        ///     取得佇列訊息數
        /// </summary>
        /// <returns> 訊息數 </returns>
        long Count();

        /// <summary>
        ///     Peek訊息
        /// </summary>
        /// <returns> 訊息 </returns>
        object PeekMsg();
    }
}
