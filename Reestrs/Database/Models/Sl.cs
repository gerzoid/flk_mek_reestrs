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
    public class SL
    {
        [Key]
        public int SLId { get; set; }

        [XmlElement("CONS")]
        public List<CONS?> CONSs { get; set; }

        [XmlElement("KSG_KPG")]
        public KSG_KPG? KSG_KPG { get; set; }

        [XmlElement("LEK_PR")]
        public List<LEK_PR?> LEK_PRs { get; set; }

        [XmlElement("NAPR")]
        public List<NAPR?> NAPRs { get; set; }

        [XmlElement("NAZ")]
        public List<NAZ?> NAZs { get; set; }

        [XmlElement("ONK_SL")]
        public ONK_SL? ONK_SL { get; set; }

        [XmlElement("USL")]
        public List<USL?> USLs { get; set; }

        [XmlElement("C_ZAB")]
        public int? C_ZAB { get; set; }

        [XmlElement("CODE_MES1")]
        public List<string?> CODE_MES1 { get; set; }

        [XmlElement("CODE_MES2")]
        [StringLength(20)]
        public string? CODE_MES2 { get; set; }

        [XmlElement("COMENTSL")]
        [StringLength(250)]
        public string? COMENTSL { get; set; }

        [XmlElement("DATE_1")]
        [Required]
        public DateTime DATE_1 { get; set; }

        [XmlElement("DATE_2")]
        [Required]
        public DateTime DATE_2 { get; set; }

        [XmlElement("DET")]
        [Required]
        public int DET { get; set; }

        [XmlElement("DISP")]
        public int? DISP { get; set; }

        [XmlElement("DN")]
        public int? DN { get; set; }

        [XmlElement("DS_ONK")]
        [Required]
        public int DS_ONK { get; set; }
        
        [XmlElement("DS0")]
        [StringLength(10)]
        public string? DS0 { get; set; }
        
        [XmlElement("DS1")]
        [StringLength(10)]
        public string? DS1 { get; set; }

        [XmlElement("DS1_PR")]
        public int? DS1_PR { get; set; }

        [XmlElement("DS2")]
        public List<string?> DS2 { get; set; }

        [XmlElement("DS2_N")]
        public List<DS2_N?> DS2_N { get; set; }

        [XmlElement("DS3")]
        public List<string?> DS3 { get; set; }

        [XmlElement("ED_COL")]
        [Precision(7,2)]
        public decimal? ED_COL { get; set; }

        [XmlElement("IDDOKT")]
        [StringLength(25)]
        [Required]
        public string IDDOKT { get; set; }

        [XmlElement("KD")]
        public int? KD { get; set; }

        [XmlElement("LPU_1")]
        [StringLength(8)]
        public string LPU_1 { get; set; }

        [XmlElement("METOD_HMP")]
        public int? METOD_HMP { get; set; }

        [XmlElement("NHISTORY")]
        [StringLength(50)]
        [Required]
        public string NHISTORY { get; set; }

        [XmlElement("P_CEL")]
        [StringLength(3)]
        public string? P_CEL { get; set; }

        [XmlElement("P_PER")]
        public int? P_PER { get; set; }

        [XmlElement("PODR")]
        public int? PODR { get; set; }

        [XmlElement("PR_D_N")]
        public int? PR_D_N { get; set; }

        [XmlElement("PROFIL")]
        [Required]
        public int PROFIL { get; set; }

        [XmlElement("PROFIL_K")]
        public int? PROFIL_K { get; set; }

        [XmlElement("PRVS")]
        [Required]
        public int PRVS { get; set; }

        [XmlElement("REAB")]
        public int? REAB { get; set; }

        [XmlElement("SL_ID")]
        [StringLength(36)]
        [Required]
        public string SL_ID { get; set; }

        [XmlElement("SUM_M")]
        [Precision(17,2)]
        [Required]
        public decimal SUM_M { get; set; }

        [XmlElement("TAL_D")]
        public DateTime? TAL_D { get; set; }

        [XmlElement("TAL_NUM")]
        [StringLength(20)]

        public string? TAL_NUM { get; set; }

        [XmlElement("TAL_P")]
        public DateTime? TAL_P { get; set; }

        [XmlElement("TARIF")]
        [Precision(17,2)]
        public decimal? TARIF { get; set; }

        [XmlElement("VERS_SPEC")]
        [StringLength(4)]
        public string? VERS_SPEC { get; set; }

        [XmlElement("VID_HMP")]
        [StringLength(12)]
        public string? VID_HMP { get; set; }

        [XmlElement("WEI")]
        [Precision(4,1)]
        public decimal? WEI { get; set; }
    }
}
