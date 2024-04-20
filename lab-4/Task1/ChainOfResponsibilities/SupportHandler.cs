using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(RequestType request);
    }
}
