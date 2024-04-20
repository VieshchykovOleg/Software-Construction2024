using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    class Level1SupportHandler : SupportHandler
    {
        public override void HandleRequest(RequestType request)
        {
            if (request == RequestType.InternetIssue)
            {
                Console.WriteLine("Проблема зі з'єднанням інтернету рішиться на рівні підтримки 1.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Не можна вирішити проблему на даному рівні підтримки.");
            }
        }
    }
}
