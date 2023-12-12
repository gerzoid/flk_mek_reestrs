using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0240 : HandlerFlk, ID, IR
    {
        public override void Handle(TreatmentCase request)
        {
            var dr = Helper.GetValueAsDateTime(request.Data?.Element("PACIENT")?.Element("DR"));
            if (dr == null)
                return;

            var date_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));

            if (dr > date_z_1)
                request.Result.Add(GetInfoOnError(request.Data, $"PACIENT/DR={dr}>DATE_Z_1={date_z_1}"));
        }
    }

}
