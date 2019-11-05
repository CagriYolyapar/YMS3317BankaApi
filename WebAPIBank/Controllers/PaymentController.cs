using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBank.Models.Context;
using WebAPIBank.Models.Entities;
using WebAPIBank.SingletonPattern;
using WebAPIBank.VMClasses;

namespace WebAPIBank.Controllers
{
    public class PaymentController : ApiController
    {
        MyContext db;
        public PaymentController()
        {
            db = DBTool.DBInstance;
        }

        [HttpPost]
        public IHttpActionResult ReceivePayment(PaymentVM item)
        {
            if (db.CardInfoes.Any(x=>x.CardNumber == item.CardNumber))
            {

               

                if (db.CardInfoes.Any(x => x.CardNumber == item.CardNumber && x.Limit >= item.PaymentPrice && x.ExpiryYear >= DateTime.Now.Year && x.ExpiryMonth >= DateTime.Now.Month))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Not Valid");
                }
            }
            else
            {
                return BadRequest("Wrong Info");
            }

       
        }


        public List<CardInfo> GetCards()
        {
            return db.CardInfoes.ToList();
        }
    }
}
