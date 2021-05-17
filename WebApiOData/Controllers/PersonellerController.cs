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
        private ODataServis db = new ODataServis();
        [EnableQuery]
        public IQueryable<Personeller> GetPersoneller()
        {
            return db.personeller;
        }
    }
}
