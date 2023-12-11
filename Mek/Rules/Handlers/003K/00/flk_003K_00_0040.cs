using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers
{
    public class flk_003K_00_0040 : HandlerFlk, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var rslt_d = request.Data?.Element("Z_SL")?.Element("RSLT_D")?.Value;
            if ((rslt_d != null) && ((rslt_d == "3") || (rslt_d == "4") || (rslt_d == "5") || (rslt_d == "31") || (rslt_d == "32")))
            {
                var sl = request.Data?.Element("Z_SL")?.Elements("SL");
                foreach (var s in sl)
                {
                    var naz_r = s.Element("NAZ")?.Element("NAZ_R")?.Value;
                    if ((naz_r == null) || (naz_r == ""))
                        request.Result.Add(GetInfoOnError(request.Data, $"Для RSLT_D={rslt_d} не заполнен NAZ_R"));
                }
            }
        }
    }
}
