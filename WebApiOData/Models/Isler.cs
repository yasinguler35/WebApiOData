using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiOData.Models
{
    [Table("Isler")]
    public class Isler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int isId { get; set; }
        public string isAd { get; set; }
        public List<PerIs> perIs { get; set; }
    }
}