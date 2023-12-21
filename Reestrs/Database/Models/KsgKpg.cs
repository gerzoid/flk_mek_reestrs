using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class KSG_KPG
    {
        [Key]
        public int KSG_KPGId { get; set; }

        [XmlElement("BZTSZ")]
        [Required]
        [Precision(8,2)]
        public decimal BZTSZ { get; set; }

        [XmlElement("CRIT")]
        public List<string> CRIT { get; set; }

        [XmlElement("IT_SL")]
        [Precision(6,5)]
        public decimal IT_SL { get; set; }

        [XmlElement("KOEF_D")]
        [Required]
        [Precision(7,5)]
        public decimal KOEF_D { get; set; }

        [XmlElement("KOEF_U")]
        [Required]
        [Precision(7,5)]
        public decimal KOEF_U { get; set; }

        [XmlElement("KOEF_UP")]
        [Required]
        [Precision(7, 5)]
        public decimal KOEF_UP { get; set; }

        [XmlElement("KOEF_Z")]
        [Required]
        [Precision(8, 5)]
        public decimal KOEF_Z { get; set; }

        [XmlElement("KSG_PG")]
        [Required]
        public int KSG_PG { get; set; }

        [XmlElement("N_KPG")]
        [StringLength(4)]
        public string N_KPG { get; set; }

        [XmlElement("N_KSG")]
        [StringLength(20)]
        public string N_KSG { get; set; }

        [XmlElement("SL_K")]
        [Required]
        public int SL_K { get; set; }

        [XmlElement("SL_KOEF")]
        public List<SL_KOEF?> SL_KOEF { get; set; }

        [XmlElement("VER_KSG")]
        [Required]
        public int VER_KSG { get; set; }
    }

}
