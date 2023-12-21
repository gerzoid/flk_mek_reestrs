using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class NAPR
    {
        [Key]
        public int NAPRId { get; set; }

        [XmlElement("MET_ISSL")]
        public int? MET_ISSL { get; set; }

        [XmlElement("NAPR_DATE")]
        [Required]
        public DateTime NAPR_DATE { get; set; }

        [XmlElement("NAPR_MO")]
        [StringLength(6)]
        public string NAPR_MO { get; set; }

        [XmlElement("NAPR_USL")]
        [StringLength(15)]
        public string NAPR_USL { get; set; }

        [XmlElement("NAPR_V")]
        [Required]
        public int NAPR_V { get; set; }
    }
}
