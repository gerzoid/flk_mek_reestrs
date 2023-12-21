using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class MR_USL_N
    {
        [Key]
        public int MR_USL_NId { get; set; }

        [XmlElement("CODE_MD")]
        [StringLength(25)]
        public string? CODE_MD { get; set; }

        [XmlElement("MR_N")]
        [Required]
        public int MR_N { get; set; }

        [XmlElement("PRVS")]
        public int? PRVS { get; set; }
    }
}
