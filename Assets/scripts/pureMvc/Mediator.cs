using support;
using System;
using System.Collections.Generic;
namespace pureMvc
{
//操作ui的中介
public class Mediator
{
    protected Facade facade;
    //mediator名字
    internal String name;
    //消息列表
    protected List<String> notificationList;
    public Mediator()
    {
        //获取类名
        this.name = this.GetType().FullName;
        this.notificationList = new List<string>();
        this.facade = Facade.getInstance();
        NotificationCenter.getInstance().addObserver(Facade.MVC_MSG, getNotificationHandler);
    }

    //获取mvc消息
    private void getNotificationHandler(object param)
    {
        Notification notification = param as Notification;
        int count = this.notificationList.Count;
        for (int i = 0; i < count; ++i)
        {
            //监听的消息名称
            String name = this.notificationList[i];
            //查找添加过感兴趣的消息
            if(name.Equals(notification.notificationName))
            {
                this.handleNotification(notification);
            }
        }
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
    /// 执行监听的方法 子类继承重写
    /// </summary>
    /// <param name="notification">消息体</param>
    /// <returns></returns>
    protected virtual void handleNotification(Notification notification)
    {
        //子类继承重写
    }

    /// <summary>
    /// 获取Mediator
    /// </summary>
    /// <param name="name">Mediator名称</param> 
    /// <returns>Mediator</returns>
    protected Mediator retrieveMediator(String name)
    {
        return this.facade.retrieveMediator(name);
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
