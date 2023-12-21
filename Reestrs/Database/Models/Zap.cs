using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class ZAP
    {
        [Key]
        public int ZAPId { get; set; }

        [XmlElement("PACIENT")]
        [Required]
        public PACIENT PACIENT { get; set; }

        [XmlElement("Z_SL")]
        [Required]
        public Z_SL Z_SL { get; set; }

        // Добавьте другие необходимые поля ZAP

    }
}
