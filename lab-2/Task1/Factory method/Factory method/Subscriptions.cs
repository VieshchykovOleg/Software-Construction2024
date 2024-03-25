using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class DomesticSubscription : ISubscription
    {
        public float GetMonthlyFee()
        {
            return 10.99f;
        }

        public int GetMinSubscriptionPeriod()
        {
            return 1;
        }

        public List<string> GetChannels()
        {
            return new List<string> { "Новини", "Розваги" };
        }
    }

    public class EducationalSubscription : ISubscription
    {
        public float GetMonthlyFee()
        {
            return 5.99f;
        }

        public int GetMinSubscriptionPeriod()
        {
            return 6;
        }

        public List<string> GetChannels()
        {
            return new List<string> { "Освітні", "Документальні" };
        }
    }

    public class PremiumSubscription : ISubscription
    {
        public float GetMonthlyFee()
        {
            return 19.99f;
        }

        public int GetMinSubscriptionPeriod()
        {
            return 12;
        }

        public List<string> GetChannels()
        {
            return new List<string> { "Всі канали" };
        }
    }

