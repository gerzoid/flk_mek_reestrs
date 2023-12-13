using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0460 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        //TODO: не проверено по реестрам
        public override void Handle(TreatmentCase request)
        {
            var usl_ok = request.Data?.Element("Z_SL")?.Element("USL_OK")?.Value;
            if ((usl_ok != null) && (usl_ok != "") && (usl_ok != "1") && (usl_ok != "2"))
            {
                var sl = request.Data?.Element("Z_SL")?.Elements("SL");
                foreach (var x in sl)
                {
                    var tarif = Helper.GetValueAsDecimal(x.Element("TARIF"));
                    var sum_m = Helper.GetValueAsDecimal(x.Element("SUM_M"));
                    if (tarif > sum_m)
                        request.Result.Add(GetInfoOnError(request.Data, $"TARIF={tarif} > SUM_M={sum_m}"));
                }
            }
        }
    }

}
