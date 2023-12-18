using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0680 : HandlerFlk, IL, IR, IH, ID, IC, IT
    {
        public override void Handle(TreatmentCase request)
        {
            //request.Lm.has
            var dr = Helper.GetValueAsDateTime(request.Lm?.Element("DR"));
            if (dr == null)
                return;
            var data_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));

            if (dr > data_z_1)
                request.Result.Add(GetInfoOnError(request.Data, $"PERS/DR={dr}>ZGLV/DATA_Z_1={data_z_1}"));
        }
    }

}
