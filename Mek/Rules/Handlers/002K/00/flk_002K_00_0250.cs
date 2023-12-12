using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0250 : HandlerFlk, ID, IR
    {
        public override void Handle(TreatmentCase request)
        {
            var dr = Helper.GetValueAsDateTime(request.Data?.Element("PACIENT")?.Element("DR"));
            if (dr == null)
                return;

            var dr_p = Helper.GetValueAsDateTime(request.Data?.Element("PACIENT")?.Element("DR_P"));
            if (dr_p == null)
                return;

            if (dr.Value.AddYears(-14) < dr_p.Value)
                request.Result.Add(GetInfoOnError(request.Data, $"PACIENT/DR (-14 лет)={dr.Value.AddYears(-14)}>DR_P={dr_p}"));
        }
    }

}
