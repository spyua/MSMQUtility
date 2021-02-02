using System;

namespace MQUtility
{
    public interface IMQ
    {
        /// <summary>
        ///     MQ Path
        /// </summary>
        string Path { get; }

        /// <summary>
        ///     Register receive event
        /// </summary>
        /// <param name="action"> Do action after receive </param>
        void RegisterReceive(Action<object> action);

        /// <summary>
        ///     Register peek event 
        /// </summary>
        /// <param name="func"> Do action after peek </param>
        void RegisterPeek(Func<object, bool> func);

        /// <summary>
        ///     Snd Message
        /// </summary>
        /// <param name="msg"> Data Message </param>
        void SendMsg(object msg);

        /// <summary>
        ///     Remove first data from queue
        /// </summary>
        void RemoveFirstData();

        /// <summary>
        ///       Remove all data from queue
        /// </summary>
        void ClearData();

        /// <summary>
        ///     Check MQ path exist.
        /// </summary>
        /// <returns> true：exist，false：none </returns>
        bool IsExists();

        /// <summary>
        ///     Get data counts from queue
        /// </summary>
        /// <returns> Count data counts from queue </returns>
        long CountData();

        /// <summary>
        ///     Try dequeue data
        /// </summary>
        /// <returns> Data </returns>
        object PeekMsg();

        /// <summary>
        ///     Dequeue data
        /// </summary>
        /// <returns> Data </returns>
        object ReceiveMsg();

        /// <summary>
        /// Delete MQ
        /// </summary>
        void DeleteQueue();
    }
}
