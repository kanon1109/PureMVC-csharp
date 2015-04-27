using System;
namespace pureMvc
{
//管理数据
public class Proxy
{
    protected Facade facade;
    //proxy名字
    internal String name;
    public Proxy()
    {
        this.name = this.GetType().FullName;
        this.facade = Facade.getInstance();
    }
    
    /// <summary>
    /// 初始化数据
    /// </summary>
    /// <returns></returns>
    public virtual void initData()
    {
        //子类继承   
    }

    /// <summary>
    /// 发送mvc消息
    /// </summary>
    /// <param name="notificationName">消息名称</param>
    /// <param name="obj">附带数据</param>
    /// <returns></returns>
    protected virtual void sendNotification(String notificationName, Object obj)
    {
        this.facade.sendNotification(notificationName, obj);
    }

    /// <summary>
    /// 发送mvc消息
    /// </summary>
    /// <param name="notificationName">消息名称</param>
    /// <returns></returns>
    protected virtual void sendNotification(String notificationName)
    {
        this.facade.sendNotification(notificationName, null);
    }

    /// <summary>
    /// 获取proxy实例
    /// </summary>
    /// <param name="name">proxy名称</param>
    /// <returns>proxy</returns>
    protected Proxy retrieveProxy(String name)
    {
        return this.facade.retrieveProxy(name);
    }
}
}
