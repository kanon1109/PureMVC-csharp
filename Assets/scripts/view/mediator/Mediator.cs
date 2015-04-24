using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Assets.scripts.view.mediator
{
//操作ui的中介
class Mediator
{
    //mediator名字
    public String name;
    public Mediator()
    {

    }

    /// <summary>
    /// 发送mvc消息
    /// </summary>
    /// <param name="notificationName"></param> 消息名称
    /// <param name="obj"></param>              附带数据
    /// <returns></returns>
    public void sendNotification(String notificationName, Object obj)
    {

    }

    /// <summary>
    /// 列出感兴趣的消息
    /// </summary>
    /// <returns></returns> 消息列表
    public List<String> listNotificationInterests()
    {
        //子类继承
        List<String> list = new List<string>();
        return list;
    }
}
}
