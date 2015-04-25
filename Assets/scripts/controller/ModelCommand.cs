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
        //在这里将所有Proxy注册创建
        Console.Write("ModelCommand execute over");
    }
}
}
