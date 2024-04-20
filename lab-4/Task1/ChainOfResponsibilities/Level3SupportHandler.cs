using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    class Level3SupportHandler : SupportHandler
    {
        public override void HandleRequest(RequestType request)
        {
            if (request == RequestType.HardwareIssue)
            {
                Console.WriteLine("Проблема з апаратною частиною рішиться на рівні підтримки 3.");
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
