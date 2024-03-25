using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public interface ISubscription
    {
        float GetMonthlyFee();
        int GetMinSubscriptionPeriod();
        List<string> GetChannels();
    }

