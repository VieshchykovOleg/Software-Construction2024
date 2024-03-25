using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Laptop : IDevice
{
    public abstract void DisplayInfo();
}


public abstract class Netbook : IDevice
{
    public abstract void DisplayInfo();
}


public abstract class EBook : IDevice
{
    public abstract void DisplayInfo();
}


public abstract class Smartphone : IDevice
{
    public abstract void DisplayInfo();
}
