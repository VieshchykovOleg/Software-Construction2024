using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    class Level2SupportHandler : SupportHandler
    {
        public override void HandleRequest(RequestType request)
        {
            if (request == RequestType.SoftwareIssue)
            {
                Console.WriteLine("Проблема з програмним забезпеченням рішиться на рівні підтримки 2.");
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
