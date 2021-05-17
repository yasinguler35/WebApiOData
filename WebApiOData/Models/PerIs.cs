using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiOData.Models
{
    [Table("PerIs")]
    public class PerIs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int perIsId { get; set; }
        public int perId { get; set; }
        public Personeller personeller { get; set; }
        public int isId { get; set; }
        public Isler isler { get; set; }
    }
}