using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIBank.Models.Entities
{
    public class CardInfo
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CardNumber { get; set; }

        public string SecurityNumber { get; set; }


        public decimal  Limit { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }


    }
}