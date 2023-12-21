using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class DS2_N
    {
        [Key]
        public int DS2_NId { get; set; }

        [XmlElement("DS2")]
        [StringLength(10)]
        [Required]
        public string DS2 { get; set; }

        [XmlElement("DS2_PR")]
        [Required]
        public int DS2_PR { get; set; }

        [XmlElement("PR_DS2_N")]
        [Required]
        public int PR_DS2_N { get; set; }
    }
}
