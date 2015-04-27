using pureMvc;
class TestProxy:Proxy
{
    //按钮按下的次数
    public int index;
    public TestProxy()
    {
        
    }

    //初始化数据
    public override void initData()
    {
        this.index = 0;
    }

    //按钮次数累加
    public void addCount()
    {
        this.index++;
        this.sendNotification("btnClick");
    }
}
