using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MvcWebRole1.Models;

namespace MvcWebRole1.Controllers
{
    public class ApiCountryCodeController : ApiController
    {
        private iptocountryEntities db = new iptocountryEntities();

        // GET api/ApiCountryCode/5
        public iptocountry Getiptocountry(string ip)
        {

            int intAddress = BitConverter.ToInt32(IPAddress.Parse(ip).GetAddressBytes().Reverse().ToArray(), 0);

            iptocountry iptocountry = db.iptocountries.Single(i => i.ipStart <= intAddress && i.ipEnd >= intAddress);
            
            if (iptocountry == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return iptocountry;
        }

    
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}