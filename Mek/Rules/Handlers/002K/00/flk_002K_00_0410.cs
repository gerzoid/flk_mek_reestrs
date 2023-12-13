using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0410 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var x in sl)
            {
                if (Convert.ToDateTime(x.Element("DATE_1").Value) > Convert.ToDateTime(x.Element("DATE_2").Value))
                {
                    request.Result.Add(GetInfoOnError(request.Data, $"DATE_1={x.Element("DATE_1").Value} > DATE_2={x.Element("DATE_2").Value}"));
                }
            }
        }
    }

}
