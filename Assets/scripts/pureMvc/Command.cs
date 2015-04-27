using System;
namespace pureMvc
{
public class Command
{
    protected Facade facade;
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
