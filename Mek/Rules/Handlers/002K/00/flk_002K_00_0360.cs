using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0360 : HandlerFlk, ID, IR
    {
        public override void Handle(TreatmentCase request)
        {
            var rslt = Helper.GetValueAsInt(request.Data?.Element("Z_SL")?.Element("RSLT"));
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var ds_onk = Helper.GetValueAsInt(s.Element("DS_ONK"));
                if (ds_onk != null && ds_onk == 1 && (rslt == 317 || rslt == 321 || rslt == 332 || rslt == 343 || rslt == 347))
                {
                    request.Result.Add(GetInfoOnError(request.Data, $"RSLT={rslt} DS_ONK={ds_onk}"));
                }
            }
        }
    }
}
