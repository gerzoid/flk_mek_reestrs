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
    public class USL
    {
        [Key]
        public int USLId { get; set; }

        [XmlElement("CODE_MD")]
        [StringLength(25)]
        public string? CODE_MD { get; set; }

        [XmlElement("CODE_USL")]
        [StringLength(20)]
        [Required]
        public string CODE_USL { get; set; }

        [XmlElement("COMENTU")]
        [StringLength(240)]
        public string? COMENTU { get; set; }

        [XmlElement("DATE_IN")]
        [Required]
        public DateTime DATE_IN { get; set; }

        [XmlElement("DATE_OUT")]
        [Required]
        public DateTime DATE_OUT { get; set; }

        [XmlElement("DET")]
        [Required]
        public int DET { get; set; }

        [XmlElement("DS")]
        [StringLength(10)]
        [Required]
        public string DS { get; set; }

        [XmlElement("IDSERV")]
        [StringLength(36)]
        [Required]
        public string IDSERV { get; set; }

        [XmlElement("KOL_USL")]
        [Required]
        [Precision(8,2)]
        public decimal KOL_USL { get; set; }

        [XmlElement("LPU")]
        [StringLength(6)]
        [Required]
        public string LPU { get; set; }

        [XmlElement("LPU_1")]
        [StringLength(8)]
        public string? LPU_1 { get; set; }

        [XmlElement("MED_DEV")]
        public List<MED_DEV?> MED_DEV { get; set; }

        [XmlElement("MR_USL_N")]
        public List<MR_USL_N?> MR_USL_N { get; set; }

        [XmlElement("NPL")]
        public int? NPL { get; set; }

        [XmlElement("P_OTK")]
        [Required]
        public int P_OTK { get; set; }

        [XmlElement("PODR")]
        public int? PODR { get; set; }

        [XmlElement("PROFIL")]
        public int? PROFIL { get; set; }

        [XmlElement("PRVS")]
        public int? PRVS { get; set; }

        [XmlElement("SUMV_USL")]
        [Precision(17,2)]
        [Required]
        public decimal SUMV_USL { get; set; }

        [XmlElement("TARIF")]
        [Precision(17,2)]
        public decimal? TARIF { get; set; }

        [XmlElement("VID_VME")]
        [StringLength(15)]
        public string? VID_VME { get; set; }
    }
}
