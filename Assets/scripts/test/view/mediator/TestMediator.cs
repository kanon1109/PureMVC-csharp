using UnityEngine;
using System.Collections;
using pureMvc;
using UnityEngine.UI;
using UnityEngine.Events;
public class TestMediator : Mediator 
{
    private TestPanel testPanel;
    private TestProxy tp;
    public TestMediator()
    {
        this.testPanel = MonoBehaviour.FindObjectOfType<TestPanel>();
        this.testPanel.btn.onClick.AddListener(delegate() {
            btnClickHandler(this.testPanel.btn.gameObject);
        });
        //添加感兴趣的消息
        this.notificationList.Add("btnClick");
        this.notificationList.Add("btnClick2");
        this.tp = this.retrieveProxy("TestProxy") as TestProxy;
    }

    private void btnClickHandler(GameObject sender)
    {
        MonoBehaviour.print("name = " + sender.name);
        this.tp.addCount();
        this.sendNotification("btnClick2");
    }

    protected override void handleNotification(Notification notification)
    {
        switch(notification.notificationName)
        {
            case "btnClick":
                //接受到了 textProxy发送来的消息
                MonoBehaviour.print("btnClick");
                this.testPanel.btn.gameObject.GetComponentInChildren<Text>().text = this.tp.index.ToString();
                break;
            case "btnClick2":
                MonoBehaviour.print("btnClick2");
                break;
        }
    }
}
