using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    [XmlRoot("ZGLV")]
    public class ZGLV_L
    {
        [Key]
        public int ZglvId { get; set; }
        [Required]
        public DateTime DATA { get; set; }
        [StringLength(26)]
        public string? FILENAME { get; set; }
        [StringLength(26)]
        public string? FILENAME1 { get; set; }
        [StringLength(5)]
        public string? VERSION { get; set; }

        [ForeignKey("PersListId")]
        public int PersListId { get; set; }
        [Required]
        public PersList PersList { get; set; }
    }

}
