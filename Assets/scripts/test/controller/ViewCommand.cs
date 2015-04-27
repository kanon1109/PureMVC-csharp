using pureMvc;
using System;
namespace Assets.scripts.controller
{
class ViewCommand:Command
{
    public override void execute(Notification notification)
    {
        //在这里将所有Mediator注册创建
        this.facade.registerMediator(new TestMediator());
        Console.Write("ViewCommand execute over");
    }
}
}
