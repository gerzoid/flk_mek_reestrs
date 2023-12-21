using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    [XmlRoot("ZGLV")]
    public class ZGLV_H
    {
        [Key]
        public int ZGLVId { get; set; }

        [XmlElement("C_OKATO1")]
        //[Required] //TODO
        [StringLength(5)]
        public string? C_OKATO1 { get; set; }

        [XmlElement("DATA")]
        [Required]
        public DateTime DATA { get; set; }

        [XmlElement("FILENAME")]
        [Required]
        [StringLength(26)]
        public string FILENAME { get; set; }

        [XmlElement("OKATO_OMS")]
        //[Required]    TODO
        [StringLength(5)]
        public string? OKATO_OMS { get; set; }

        [XmlElement("SD_Z")]
        [Required]
        public int SD_Z { get; set; }

        [XmlElement("VERSION")]
        [Required]
        [StringLength(5)]
        public string VERSION { get; set; }
    }

}
