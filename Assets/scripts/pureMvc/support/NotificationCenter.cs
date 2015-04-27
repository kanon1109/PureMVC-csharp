using System;
using System.Collections.Generic;
namespace support
{
public class NotificationCenter
{
    //单例
    private static NotificationCenter instance;
    //方法回调类型
    public delegate void HandlerDelegate(Object param);
    //存放回调列表的字典
    private Dictionary<String, List<HandlerDelegate>> dict;
    public NotificationCenter()
    {
        this.dict = new Dictionary<string, List<HandlerDelegate>>();
    }

    //获取单例
    public static NotificationCenter getInstance()
    {
        if(instance == null) instance = new NotificationCenter();
        return instance;
    }

    /**
     * 发送消息
     * @param	name    消息名称
     * @param	obj     消息所带参数
     * returns
     */
    public void postNotification(String name, Object obj)
    {
        if (!this.dict.ContainsKey(name)) return;
        List<HandlerDelegate> delegateList = this.dict[name];
        int count = delegateList.Count;
        for (int i = 0; i < count; ++i)
        {
            HandlerDelegate handler = delegateList[i];
            handler.Invoke(obj);
        }
    }

    /**
     * 发送消息
     * @param	name    消息名称
     * @param	obj     消息所带参数
     * returns
     */
    public void postNotification(String name)
    {
        this.postNotification(name, null);
    }

    /**
     * 添加消息观察者
     * @param	name        消息名称
     * @param	handler     消息的回调
     * returns
     */
    public void addObserver(String name, HandlerDelegate handler)
    {
        List<HandlerDelegate> delegateList;
        if (!this.dict.ContainsKey(name))
        {
            //根据消息名称创建回调列表
            delegateList = new List<HandlerDelegate>();
            delegateList.Add(handler);
            this.dict.Add(name, delegateList);
        }
        else
        {
            //已经创建了回调列表则直接使用
            delegateList = this.dict[name];
            delegateList.Add(handler);
        }
    }

    /**
     * 删除此消息的所有观察者
     * @param	name    消息名称
     * returns
     */
    public void removeObserver(String name)
    {
        if (!this.dict.ContainsKey(name)) return;
        List<HandlerDelegate> delegateList = this.dict[name];
        delegateList.Clear();
    }
    
    /**
     * 删除所有观察者
     * returns
     */
    public void removeObservers()
    {
        this.dict.Clear();
    }
}
}
