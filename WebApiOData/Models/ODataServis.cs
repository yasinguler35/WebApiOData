using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiOData.Models
{
    public class ODataServis:DbContext
    {
        public ODataServis():base("name=ODataEntity")
        {

        }
        public DbSet<Personeller> personeller { get; set; }
        public DbSet<Isler> isler { get; set; }
        public DbSet<PerIs> perIs { get; set; }
    }
}