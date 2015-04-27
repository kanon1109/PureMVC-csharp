using System;
using pureMvc;
namespace Assets.scripts.controller
{
class ModelCommand:Command
{
    public override void execute(Notification notification)
    {
        //在这里将所有Proxy注册创建
        this.facade.registerProxy(new TestProxy());
        Console.Write("ModelCommand execute over");
    }
}
}
