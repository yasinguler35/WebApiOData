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


        //perAd 'A' ile başlayanlar
        //http://localhost:57962/odata/Personeller?$filter=startswith(perAd,'A')
        //perAd 'A' ile başlamayanlar
        // http://localhost:57962/odata/Personeller?$filter=startswith(perAd,'A') eq false

        //perAd 'A' ile başlamayanlar ve yaşı 49 büyük olanların perAd ve perId getir
        //http://localhost:57962/odata/Personeller?$filter=startswith(perAd,'A') eq false and (perYas gt 49) &$select=perAd,perId

        //döküman linki
        //https://www.odata.org/documentation/odata-version-2-0/uri-conventions/

        //orderby kullanımı 
        //http://localhost:57962/odata/Personeller?$orderby=perYas desc
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
