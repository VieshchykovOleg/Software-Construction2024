using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class DocumentBuilder
{
    public abstract void BuildHeader();
    public abstract void BuildBody();
    public abstract void BuildFooter();

    public void BuildDocument()
    {
        BuildHeader();
        BuildBody();
        BuildFooter();
    }
}

