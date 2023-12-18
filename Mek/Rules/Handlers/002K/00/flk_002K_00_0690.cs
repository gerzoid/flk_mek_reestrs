using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0690 : HandlerFlk, IL, IR, IH, ID, IC, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var dr_p = Helper.GetValueAsDateTime(request.Lm?.Element("DR_P"));
            if (dr_p == null)
                return;

            var dr = Helper.GetValueAsDateTime(request.Lm?.Element("DR"));
            if (dr == null)
                return;

            if (dr.Value.AddYears(-14) < dr_p.Value)
                request.Result.Add(GetInfoOnError(request.Data, $"PERS/DR (-14 лет)={dr.Value.AddYears(-14)}>DR_P={dr_p}"));
        }
    }

}
