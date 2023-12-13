using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0350 : HandlerFlk, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var rslt_d = Helper.GetValueAsInt(request.Data?.Element("Z_SL")?.Element("RSLT_D"));
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var ds_onk = Helper.GetValueAsInt(s.Element("DS_ONK"));
                if (ds_onk != null && ds_onk == 1 && rslt_d == 1)
                {
                    request.Result.Add(GetInfoOnError(request.Data, $"RSLT_D={rslt_d} DS_ONK={ds_onk}"));
                }
            }
        }
    }
}
