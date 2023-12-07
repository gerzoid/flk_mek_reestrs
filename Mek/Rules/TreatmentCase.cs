using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mek.Rules
{
    public class TreatmentCase
    {
        public XElement Zglv { get; set; }
        public XElement Schet { get; set; }
        public XElement Data { get; set; }
        //public XDocument Data { get; set; }
        public List<FlkError> Result { get; set; }

        public XElement Lm { get; set; }
    }
}
