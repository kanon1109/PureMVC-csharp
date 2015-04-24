using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.scripts.model;
namespace Assets.scripts.controller
{
class ModelCommand:Command
{
    public override void execute(Notification notification)
    {
        //this.facade.registerMediator(new TestMediator());
        Console.Write("ModelCommand execute");
        base.execute(notification);
    }
}
}
