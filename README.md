# MSMQUtility
Microsoft Message Queuing Utility. 

## Demo

![image](https://user-images.githubusercontent.com/20264622/106613862-a2c8a600-65a5-11eb-8e97-e58e80136667.png)


## Usage

 - Create MQ Pool
 ```
 var mqpool = new MQPool("Name").AddTargetMQ("Target Name")
 ```
 
 - Register Receive
 ```
  mqPool.RegisterRcv("Name", obj =>{
        var msg = obj as DefinitionObject;
                ...
            });
 ```
 
 - Snd Msg
 ```
  mqPool.SendMsg("Target Name")
 ```
 
 - Clear All Data
 ```
   mqPool.ClearData("Name");
 ```
 
 - Dequeue Data
 ```
   mqPool.ReceiveMsg<object>("Name");
 ```
 
 - TryDequeue Data
 ```
   mqPool.PeekMsg<object>("Name");
 ```

## Support Base API Function

```IMQ
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
```
