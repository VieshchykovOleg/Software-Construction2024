using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VisibleState : IState
{
    private LightElementNode element;

    public VisibleState(LightElementNode element)
    {
        this.element = element;
    }

    public void Handle()
    {
      
        element.AddClass("visible");
    }
}
