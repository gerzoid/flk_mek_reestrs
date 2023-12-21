using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class B_DIAG
    {
        [Key]
        public int B_DIAGId { get; set; }

        [XmlElement("DIAG_CODE")]
        [Required]
        public int DIAG_CODE { get; set; }

        [XmlElement("DIAG_DATE")]
        [Required]
        public DateTime DIAG_DATE { get; set; }

        [XmlElement("DIAG_RSLT")]
        public int? DIAG_RSLT { get; set; }

        [XmlElement("DIAG_TIP")]
        [Required]
        public int DIAG_TIP { get; set; }

        [XmlElement("REC_RSLT")]
        public int? REC_RSLT { get; set; }
    }
}
