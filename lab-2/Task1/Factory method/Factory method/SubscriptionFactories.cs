using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WebSite : ISubscriptionFactory
{
    public ISubscription CreateSubscription()
    {
        return new DomesticSubscription();
    }
}

public class MobileApp : ISubscriptionFactory
{
    public ISubscription CreateSubscription()
    {
        return new PremiumSubscription();
    }
}

public class ManagerCall : ISubscriptionFactory
{
    public ISubscription CreateSubscription()
    {
        return new EducationalSubscription();
    }
}
