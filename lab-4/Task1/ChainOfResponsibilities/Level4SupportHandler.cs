using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    class Level4SupportHandler : SupportHandler
    {
        public override void HandleRequest(RequestType request)
        {
            if (request == RequestType.OtherIssue)
            {
                Console.WriteLine("Проблема рішиться на рівні підтримки 4.");
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
