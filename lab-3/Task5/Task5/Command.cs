using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICommand
{
    void Execute();
}

public class AddClassCommand : ICommand
{
    private LightElementNode element;
    private string className;

    public AddClassCommand(LightElementNode element, string className)
    {
        this.element = element;
        this.className = className;
    }

    public void Execute()
    {
        element.Classes.Add(className);
    }
}

