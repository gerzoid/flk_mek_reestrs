using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0430 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var x in sl)
            {
                var ds1 = x.Element("DS1").Value;
                var ds2 = x.Element("DS2")?.Value;
                var ds3 = x.Element("DS3")?.Value;
                //var ds2 = x.Element("DS2_N") != null ? x.Element("DS2_N").Element("DS2") != null ? x.Element("DS2_N").Element("DS2").Value : "" : "";
                //var ds3 = x.Element("DS3") != null ? x.Element("DS3").Value : "";
                if ((ds1 == ds2) || (ds1 == ds3))
                    request.Result.Add(GetInfoOnError(request.Data, $"DS1={ds1}==DS2={ds2}"));
            }
        }
    }
}
