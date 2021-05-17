using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class PersonellerController : ODataController
    {
        //tabloda select yapma
        //http://localhost:57962/odata/Personeller?$select=perId,perAd

        //personel id si 1 olanı getir
        //http://localhost:57962/odata/Personeller?$filter=perId eq 1
        private ODataServis db = new ODataServis();
        [EnableQuery]
        public IQueryable<Personeller> GetPersoneller()
        {
            return db.personeller;
        }
        //http://localhost:57962/odata/Personeller(3)/perAd
        //http://localhost:57962/odata/Personeller(3)/perAd/$value
        //neyi istiyorsak geri dönüş değeri olarak getden sonra ol yazılır GetperAd gibi
        [HttpGet]
        public IHttpActionResult GetperAd([FromODataUri] int key) 
        {
            var personel = db.personeller.Find(key);
            if (personel==null)
            {
                return NotFound();
            }
            return Ok(personel.perAd);
        }
    }
}
