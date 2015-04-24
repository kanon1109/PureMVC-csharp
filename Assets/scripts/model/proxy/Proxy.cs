using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Assets.scripts.proxy
{
//管理数据
class Proxy
{
    public String name;
    public Proxy()
    {

    }
    
    /// <summary>
    /// 初始化数据
    /// </summary>
    /// <returns></returns>
    public void initData()
    {
        //子类继承   
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
}
}
