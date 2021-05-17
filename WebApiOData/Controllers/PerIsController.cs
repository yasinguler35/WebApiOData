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
        //iki tabloyu birleştirme
        //http://localhost:57962/odata/PerIs?$expand=personeller
        //select ve expand kullanıldı
        //http://localhost:57962/odata/PerIs?$expand=personeller&$select=perId,isId,personeller
        private ODataServis db = new ODataServis();
        [EnableQuery]
        public IQueryable<PerIs> GetPerIs()
        {
            return db.perIs;
        }
    }
}
