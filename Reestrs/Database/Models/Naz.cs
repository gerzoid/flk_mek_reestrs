using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class NAZ
    {
        [Key]
        public int NAZId { get; set; }

        [XmlElement("NAPR_DATE")]
        public DateTime? NAPR_DATE { get; set; }

        [XmlElement("NAPR_MO")]
        [StringLength(6)]
        public string? NAPR_MO { get; set; }

        [XmlElement("NAZ_N")]
        [Required]
        public int NAZ_N { get; set; }

        [XmlElement("NAZ_PK")]
        public int? NAZ_PK { get; set; }

        [XmlElement("NAZ_PMP")]
        public int? NAZ_PMP { get; set; }

        [XmlElement("NAZ_R")]
        [Required]
        public int NAZ_R { get; set; }

        [XmlElement("NAZ_SP")]
        public int? NAZ_SP { get; set; }

        [XmlElement("NAZ_USL")]
        [StringLength(15)]
        public string? NAZ_USL { get; set; }

        [XmlElement("NAZ_V")]
        public int? NAZ_V { get; set; }
    }
}
