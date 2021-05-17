using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiOData.Models
{
    [Table("Personeller")]
    public class Personeller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int perId { get; set; }
        public string perAd { get; set; }
        public string perSoyad { get; set; }
        public int perYas { get; set; }
        public List<PerIs> perIs { get; set; }
    }
}