using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0370 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var sum_v = Convert.ToDecimal(request.Data?.Element("Z_SL")?.Element("SUMV")?.Value.Replace('.', ','));
            var sum_sum_m = request.Data?.Element("Z_SL")?.Elements("SL").Sum(d => Convert.ToDecimal(d.Element("SUM_M").Value.Replace('.', ',')));
            if (sum_v != sum_sum_m)
            {
                request.Result.Add(GetInfoOnError(request.Data, $"SUM_V={sum_v}!=SUM(SUM_M)={sum_sum_m}"));
            }
        }
    }

}
