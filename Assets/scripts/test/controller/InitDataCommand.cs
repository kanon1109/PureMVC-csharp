using System;
using pureMvc;
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
