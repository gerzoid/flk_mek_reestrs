using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0450 : HandlerFlk, IC, ID, IH, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var x in sl)
            {
                var code_mes1 = x.Element("CODE_MES1")?.Value;
                var code_mes2 = x.Element("CODE_MES2")?.Value;
                if (code_mes1 != null && code_mes2 != null && code_mes1 == code_mes2)
                    request.Result.Add(GetInfoOnError(request.Data, $"CODE_MES1={code_mes1} = CODE_MES2={code_mes2}"));
            }
        }
    }

}
