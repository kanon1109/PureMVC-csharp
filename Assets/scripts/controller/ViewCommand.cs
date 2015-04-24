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

    override void execute(Notification notification)
    {
        //this.facade.registerMediator(new TestMediator());
        Console.Write("ViewCommand execute");
        base.execute(notification);
    }
}
}
