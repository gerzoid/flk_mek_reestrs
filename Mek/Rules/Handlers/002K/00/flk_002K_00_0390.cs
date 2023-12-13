using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0390 : HandlerFlk, IC, ID, IH, IR
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var reab = s.Element("REAB")?.Value;
                if (reab != null)
                {
                    var novor = request.Data?.Element("PACIENT")?.Element("NOVOR")?.Value;
                    if (novor != "0")
                        request.Result.Add(GetInfoOnError(request.Data, $"REAB={reab} при NOVOR={novor}"));
                }
            }
        }
    }
}
