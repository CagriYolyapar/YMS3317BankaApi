using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Context;
using WebAPIBank.Models.Entities;

namespace WebAPIBank.StrategyPattern
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            CardInfo ci = new CardInfo();
            ci.FirstName = "Tamer";
            ci.LastName = "Bozkaya";
            ci.ExpiryYear = 2020;
            ci.ExpiryMonth = 5;
            ci.Limit = 30000;
            ci.CardNumber = "1111 1111 1111 1111";
            ci.SecurityNumber = "123";

            context.CardInfoes.Add(ci);
            context.SaveChanges();
        }
    }
}