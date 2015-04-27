using System;
using System.Collections.Generic;
using support;
namespace pureMvc
{
//Facade用于初始化注册Mediator，Proxy，发送mvc消息（消息模块独立于mvc）
public class Facade
{
    //存放mediator的字典
    private Dictionary<String, Mediator> mediatorDict;
    //存放proxy的字典
    private Dictionary<String, Proxy> proxyDict;
    //单例
    private static Facade instance = null;
    //mvc内部消息名称
    public static String MVC_MSG = "mvc_msg";
    public Facade()
    {
        this.mediatorDict = new Dictionary<String, Mediator>();
        this.proxyDict = new Dictionary<String, Proxy>();
    }

    //获取单例
    public static Facade getInstance()
    {
        if(instance == null) instance = new Facade();
        return instance;
    }

    /// <summary>
    /// 获取proxy实例
    /// </summary>
    /// <param name="name"></param> proxy名称
    /// <returns></returns>
    public Proxy retrieveProxy(String name)
    {
        return this.proxyDict[name];
    }


    /// <summary>
    /// 获取mediator实例
    /// </summary>
    /// <param name="name"></param> mediator名称
    /// <returns></returns>
    public Mediator retrieveMediator(String name)
    {
        return this.mediatorDict[name];
    }

    /// <summary>
    /// 注册mediator
    /// </summary>
    /// <param name="mediator"></param>
    /// <returns></returns>
    public void registerMediator(Mediator mediator)
    {
        this.mediatorDict.Add(mediator.name, mediator);
    }

    /// <summary>
    /// 注册proxy
    /// </summary>
    /// <param name="proxy"></param>
    /// <returns></returns>
    public void registerProxy(Proxy proxy)
    {
        this.proxyDict.Add(proxy.name, proxy);
    }

    /// <summary>
    /// 初始化proxy
    /// </summary>
    /// <returns></returns>
    public void initProxyData()
    {
        foreach (KeyValuePair<String, Proxy> kvp in this.proxyDict)
        {
            Proxy proxy = kvp.Value;
            proxy.initData();
        }
    }

    /// <summary>
    /// 发送mvc消息
    /// </summary>
    /// <param name="notificationName"></param> 消息名称
    /// <param name="obj"></param>              附带数据
    /// <returns></returns>
    public void sendNotification(String notificationName, Object obj)
    {
        Notification notification = new Notification();
        notification.notificationName = notificationName;
        notification.obj = obj;
        NotificationCenter.getInstance().postNotification(MVC_MSG, notification);
    }

    /// <summary>
    /// 发送不带参数的消息
    /// </summary>
    /// <param name="notificationName"></param>
    /// <returns></returns>
    public void sendNotification(String notificationName)
    {
        this.sendNotification(notificationName, null);
    }
}
}
