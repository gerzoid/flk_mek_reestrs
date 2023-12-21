using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class PACIENT
    {
        [Key]
        public int PACIENTId { get; set; }

        [XmlElement("COMENTP")]
        [StringLength(250)]
        public string? COMENTP { get; set; }

        [XmlElement("DOCDATE")]
        public DateTime? DOCDATE { get; set; }

        [XmlElement("DOCNUM")]
        [StringLength(10)]
        public string? DOCNUM { get; set; }

        [XmlElement("DOCORG")]
        [StringLength(1000)]
        public string? DOCORG { get; set; }

        [XmlElement("DOCSER")]
        [StringLength(10)]
        public string? DOCSER { get; set; }

        [XmlElement("DOCTYPE")]
        [StringLength(2)]
        public string? DOCTYPE { get; set; }

        [XmlElement("DOST")]
        public List<int?> DOST { get; set; }

        [XmlElement("DOST_P")]
        public List<int?> DOST_P { get; set; }

        [XmlElement("DR")]
        [Required]
        public DateTime DR { get; set; }

        [XmlElement("DR_P")]
        public DateTime? DR_P { get; set; }

        [XmlElement("ENP")]
        [StringLength(16)]
        public string? ENP { get; set; }

        [XmlElement("FAM")]
        [StringLength(40)]
        public string? FAM { get; set; }

        [XmlElement("FAM_P")]
        [StringLength(40)]
        public string? FAM_P { get; set; }

        [XmlElement("ID_PAC")]
        [StringLength(36)]
        [Required]
        public string ID_PAC { get; set; }

        [XmlElement("IM")]
        [StringLength(40)]
        public string? IM { get; set; }

        [XmlElement("IM_P")]
        [StringLength(40)]
        public string? IM_P { get; set; }

        [XmlElement("INV")]
        public int? INV { get; set; }

        [XmlElement("MR")]
        [StringLength(100)]
        public string? MR { get; set; }

        [XmlElement("MSE")]
        public int? MSE { get; set; }

        [XmlElement("NOVOR")]
        [StringLength(9)]
        [Required]
        public string NOVOR { get; set; }

        [XmlElement("NPOLIS")]
        [StringLength(20)]
        public string? NPOLIS { get; set; }

        [XmlElement("OKATOG")]
        [StringLength(11)]
        public string? OKATOG { get; set; }

        [XmlElement("OKATOP")]
        [StringLength(11)]
        public string? OKATOP { get; set; }

        [XmlElement("OT")]
        [StringLength(40)]
        public string? OT { get; set; }

        [XmlElement("OT_P")]
        [StringLength(40)]
        public string? OT_P { get; set; }

        [XmlElement("SMO")]
        [StringLength(5)]

        public string? SMO { get; set; }

        [XmlElement("SMO_NAM")]
        [StringLength(100)]
        public string? SMO_NAM { get; set; }

        [XmlElement("SMO_OGRN")]
        [StringLength(15)]
        public string? SMO_OGRN { get; set; }
            
        [XmlElement("SMO_OK")]
        [StringLength(5)]
        public string? SMO_OK { get; set; }

        [XmlElement("SNILS")]
        [StringLength(14)]
        public string? SNILS { get; set; }

        [XmlElement("SPOLIS")]
        [StringLength(10)]
        public string? SPOLIS { get; set; }

        [XmlElement("ST_OKATO")]
        [StringLength(5)]
        public string? ST_OKATO { get; set; }

        [XmlElement("VNOV_D")]
        public int? VNOV_D { get; set; }

        [XmlElement("VPOLIS")]
        [Required]
        public int? VPOLIS { get; set; }

        [XmlElement("W")]
        public int? W { get; set; }

        [XmlElement("W_P")]
        public int? W_P { get; set; }
    }
}
