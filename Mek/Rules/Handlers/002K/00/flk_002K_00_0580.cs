using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0580 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var napr = s.Elements("NAPR");
                foreach (var n in napr)
                {
                    var napr_date = Helper.GetValueAsDateTime(n.Element("NAPR_DATE"));
                    var date_2 = Helper.GetValueAsDateTime(s.Element("DATE_2"));
                    if ((napr_date == null) || (napr_date > date_2))
                        request.Result.Add(GetInfoOnError(request.Data, $"NAPR_DATE={napr_date} > DATE_2={date_2}"));
                }
            }
        }
    }

}
