using System;

class Program
{
    static void Main(string[] args)
    {
        DeviceFactory factory = new IProneFactory();

        Laptop laptop = factory.CreateLaptop();
        Netbook netbook = factory.CreateNetbook();
        EBook ebook = factory.CreateEBook();
        Smartphone smartphone = factory.CreateSmartphone();

        laptop.DisplayInfo();
        netbook.DisplayInfo();
        ebook.DisplayInfo();
        smartphone.DisplayInfo();
    }
}
