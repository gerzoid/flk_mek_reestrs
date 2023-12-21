using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class ONK_USL
    {
        [Key]
        public int ONK_USLId { get; set; }

        [XmlElement("HIR_TIP")]
        public int? HIR_TIP { get; set; }

        [XmlElement("LEK_PR")]
        public List<LEK_PR?> LEK_PR { get; set; }

        [XmlElement("LEK_TIP_L")]
        public int? LEK_TIP_L { get; set; }

        [XmlElement("LEK_TIP_V")]
        public int? LEK_TIP_V { get; set; }

        [XmlElement("LUCH_TIP")]
        public int? LUCH_TIP { get; set; }

        [XmlElement("PPTR")]
        public int? PPTR { get; set; }

        [XmlElement("USL_TIP")]
        [Required]
        public int USL_TIP { get; set; }
    }
}
