using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.scripts.model;
namespace Assets.scripts.controller
{
class InitDataCommand:Command
{
    override public void execute(Notification notification)
    {
        this.facade.initProxyData();
        Console.Write("InitDataCommand execute");
    }
}
}
