using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    [XmlRoot(ElementName = "PERS_LIST", Namespace = "")]
    public class PersList
    {
        [Key]
        public int PersListId { get; set; }

        [XmlElement("PERS")]
        public List<Pers> PERS { get; set; }

        public ZGLV_L ZGLV { get; set; }

        public SANK SANK { get; set; }

        public PersList()
        {
            PERS = new List<Pers>();
        }
    }

}
