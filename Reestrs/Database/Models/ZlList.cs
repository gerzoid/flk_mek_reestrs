using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class ZL_LIST
    {
        [Key]
        public int ZL_LISTId { get; set; }

        [XmlElement("SCHET")]
        [Required]
        public SCHET SCHET { get; set; }

        [XmlElement("ZAP")]
        [Required]
        public List<ZAP> ZAPs { get; set; }

        [XmlElement("ZGLV")]
        [Required]
        public ZGLV_H ZGLV { get; set; }
    }
}
