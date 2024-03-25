using System;


class Program
{
    static void Main(string[] args)
    {
     
        Authenticator auth1 = Authenticator.GetInstance();
        Authenticator auth2 = Authenticator.GetInstance();

        if (auth1 == auth2)
        {
            Console.WriteLine("auth1 та auth2 вказують на один і той же екземпляр Authenticator.");
        }
        else
        {
            Console.WriteLine("auth1 та auth2 не вказують на один і той же екземпляр Authenticator.");
        }
    }
}
