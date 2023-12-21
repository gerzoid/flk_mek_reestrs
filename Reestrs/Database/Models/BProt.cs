using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class B_PROT
    {
        [Key]
        public int B_PROTId { get; set; }

        [XmlElement("D_PROT")]
        [Required]
        public DateTime D_PROT { get; set; }

        [XmlElement("PROT")]
        [Required]
        public int PROT { get; set; }
    }
}
