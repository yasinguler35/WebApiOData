using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class PersonellerController : ApiController
    {
        private ODataServis db = new ODataServis();
        public IQueryable<Personeller> GetPersoneller()
        {
            return db.personeller;
        }
    }
}
