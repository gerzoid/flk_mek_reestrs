using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class MED_DEV
    {
        [Key]
        public int MED_DEVId { get; set; }

        [XmlElement("CODE_MEDDEV")]
        [Required]
        public int CODE_MEDDEV { get; set; }

        [XmlElement("DATE_MED")]
        [Required]
        public DateTime DATE_MED { get; set; }

        [XmlElement("NUMBER_SER")]
        [StringLength(100)]
        [Required]
        public string NUMBER_SER { get; set; }
    }
}
