using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class CONS
    {
        [Key]
        public int CONSId { get; set; }

        [XmlElement("DT_CONS")]
        [Required]
        public DateTime DT_CONS { get; set; }

        [XmlElement("PR_CONS")]
        [Required]
        public int PR_CONS { get; set; }
    }
}
