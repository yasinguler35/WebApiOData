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
    public class PerIsController : ODataController
    {
        private ODataServis db = new ODataServis();
        [EnableQuery]
        public IQueryable<PerIs> GetPerIs()
        {
            return db.perIs;
        }
    }
}
