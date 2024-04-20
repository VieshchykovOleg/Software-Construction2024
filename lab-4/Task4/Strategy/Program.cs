using System;
using System.IO;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Image localImage = new Image(new FileSystemImageLoader());
        byte[] localData = localImage.Load(@"E:\2_cyrs\2semestr\Software-Construction2024\lab-4\Task4\test.jpg");



        Image networkImage = new Image(new NetworkImageLoader());
        byte[] networkData = networkImage.Load("https://pixnio.com/uk/media/uk-3084564");

        Console.WriteLine("Images loaded successfully");
    }
}
