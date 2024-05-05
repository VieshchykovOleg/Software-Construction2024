using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyDocumentBuilder : DocumentBuilder
{
    public override void BuildHeader()
    {
        Console.WriteLine("Building header...");
    }

    public override void BuildBody()
    {
        Console.WriteLine("Building body...");
    }

    public override void BuildFooter()
    {
        Console.WriteLine("Building footer...");
    }
}
