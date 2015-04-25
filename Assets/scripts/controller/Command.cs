using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.scripts.model;
namespace Assets.scripts.controller
{
class Command
{
    public Facade facade;
    public Command()
    {
        this.facade = Facade.getInstance();
    }

    //执行
    public virtual void execute(Notification notification)
    {
        //子类继承
        Console.Write("Command execute");
    }
}
}
