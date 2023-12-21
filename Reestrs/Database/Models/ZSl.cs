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
    public class Z_SL
    {
        [Key]
        public int Z_SLId { get; set; }

        [XmlElement("SANK")]
        public List<SANK> SANKs { get; set; }

        [XmlElement("SL")]
        [Required]
        public List<SL> SLs { get; set; }

        [XmlElement("DATE_Z_1")]
        [Required]
        public DateTime DATE_Z_1 { get; set; }

        [XmlElement("DATE_Z_2")]
        [Required]
        public DateTime DATE_Z_2 { get; set; }

        [XmlElement("FOR_POM")]
        [Required]
        public int FOR_POM { get; set; }

        [XmlElement("IDCASE")]
        [Required]
        public int IDCASE { get; set; }

        [XmlElement("IDSP")]
        [Required]
        public int IDSP { get; set; }

        [XmlElement("ISHOD")]
        [Required]
        public int ISHOD { get; set; }

        [XmlElement("KD_Z")]
        public int? KD_Z { get; set; }

        [XmlElement("LPU")]
        [StringLength(6)]
        [Required]
        public string LPU { get; set; }

        [XmlElement("NPR_DATE")]
        public DateTime? NPR_DATE { get; set; }

        [XmlElement("NPR_MO")]
        [StringLength(6)]
        public string? NPR_MO { get; set; }

        [XmlElement("OPLATA")]
        public int? OPLATA { get; set; }

        [XmlElement("OS_SLUCH")]
        public int? OS_SLUCH { get; set; }

        [XmlElement("P_DISP2")]
        public int? P_DISP2 { get; set; }

        [XmlElement("P_OTK")]
        [Required]
        public int P_OTK { get; set; }

        [XmlElement("RSLT")]
        [Required]
        public int RSLT { get; set; }

        [XmlElement("RSLT_D")]
        public int? RSLT_D { get; set; }

        [XmlElement("SUMP")]
        [Precision(17,2)]
        public decimal? SUMP { get; set; }

        [XmlElement("SUMV")]
        [Precision(17,2)]
        [Required]
        public decimal SUMV { get; set; }

        [XmlElement("USL_OK")]
        [Required]
        public int USL_OK { get; set; }

        [XmlElement("VB_P")]
        public int? VB_P { get; set; }

        [XmlElement("VBR")]
        [Required]
        public int VBR { get; set; }

        [XmlElement("VIDPOM")]
        [Required]
        public int VIDPOM { get; set; }

        [XmlElement("VNOV_M")]
        public int? VNOV_M { get; set; }
    }
}
