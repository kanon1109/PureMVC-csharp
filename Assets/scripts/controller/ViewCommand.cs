using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.scripts.model;
namespace Assets.scripts.controller
{
class ViewCommand:Command
{
    //视图command
    public ViewCommand()
    {

    }

    public override void execute(Notification notification)
    {
        //在这里将所有Mediator注册创建
        //this.facade.registerMediator(new TestMediator());
        Console.Write("ViewCommand execute over");
    }
}
}
