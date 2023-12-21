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
    public class ONK_SL
    {
        [Key]
        public int ONK_SLId { get; set; }

        [XmlElement("B_DIAG")]
        public List<B_DIAG?> B_DIAG { get; set; }

        [XmlElement("B_PROT")]
        public List<B_PROT?> B_PROT { get; set; }

        [XmlElement("BSA")]
        [Precision(3,2)]
        public decimal BSA { get; set; }

        [XmlElement("DS1_T")]
        [Required]
        public int DS1_T { get; set; }

        [XmlElement("HEI")]
        public int? HEI { get; set; }

        [XmlElement("K_FR")]
        public int? K_FR { get; set; }

        [XmlElement("MTSTZ")]
        public int? MTSTZ { get; set; }

        [XmlElement("ONK_M")]
        public int? ONK_M { get; set; }

        [XmlElement("ONK_N")]
        public int? ONK_N { get; set; }

        [XmlElement("ONK_T")]
        public int? ONK_T { get; set; }

        [XmlElement("ONK_USL")]
        public List<ONK_USL?> ONK_USL { get; set; }

        [XmlElement("SOD")]
        [Precision(6,2)]
        public decimal SOD { get; set; }

        [XmlElement("STAD")]
        public int? STAD { get; set; }

        [XmlElement("WEI")]
        [Precision(4,1)]
        public decimal? WEI { get; set; }
    }

}
