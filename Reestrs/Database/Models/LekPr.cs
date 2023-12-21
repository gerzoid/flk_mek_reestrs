using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class LEK_PR
    {
        [Key]
        public int LEK_PRId { get; set; }

        [XmlElement("COD_MARK")]
        [StringLength(100)]
        public string? COD_MARK { get; set; }

        [XmlElement("CODE_SH")]
        [StringLength(10)]
        [Required]
        public string CODE_SH { get; set; }

        [XmlElement("DATA_INJ")]
        [Required]
        public DateTime DATA_INJ { get; set; }

        [XmlElement("LEK_DOSE")]
        public LEK_DOSE? LEK_DOSE { get; set; }

        [XmlElement("REGNUM")]
        [StringLength(6)]
        public string REGNUM { get; set; }
    }
}
