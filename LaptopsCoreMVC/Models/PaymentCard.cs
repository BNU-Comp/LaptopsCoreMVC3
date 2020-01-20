using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    public class PaymentCard
    {
        public int PaymentCardID { get; set; }

        // Name on Card
        public string CardName { get; set; }

        public string CardNumber { get; set; }

        public CardTypes CardType { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }
    }

    public enum CardTypes
    {
        Visa,
        MasterCard,
        AmericanExpress
    }
}
