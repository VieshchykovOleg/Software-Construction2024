using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        ISubscriptionFactory website = new WebSite();
        ISubscriptionFactory mobileApp = new MobileApp();
        ISubscriptionFactory managerCall = new ManagerCall();

        ISubscription websiteSubscription = website.CreateSubscription();
        ISubscription mobileAppSubscription = mobileApp.CreateSubscription();
        ISubscription managerCallSubscription = managerCall.CreateSubscription();

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Підписка на веб-сайті:");
        Console.WriteLine($"Щомісячна плата: ${websiteSubscription.GetMonthlyFee()}");
        Console.WriteLine($"Мінімальний період підписки: {websiteSubscription.GetMinSubscriptionPeriod()} місяців");
        Console.WriteLine("Канали: " + string.Join(", ", websiteSubscription.GetChannels()));
        Console.WriteLine();

        Console.WriteLine("Підписка у мобільному додатку:");
        Console.WriteLine($"Щомісячна плата: ${mobileAppSubscription.GetMonthlyFee()}");
        Console.WriteLine($"Мінімальний період підписки: {mobileAppSubscription.GetMinSubscriptionPeriod()} місяців");
        Console.WriteLine("Канали: " + string.Join(", ", mobileAppSubscription.GetChannels()));
        Console.WriteLine();

        Console.WriteLine("Підписка через дзвінок менеджеру:");
        Console.WriteLine($"Щомісячна плата: ${managerCallSubscription.GetMonthlyFee()}");
        Console.WriteLine($"Мінімальний період підписки: {managerCallSubscription.GetMinSubscriptionPeriod()} місяців");
        Console.WriteLine("Канали: " + string.Join(", ", managerCallSubscription.GetChannels()));
    }
}
