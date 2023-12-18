using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0670 : HandlerFlk, IL, IR, IH, ID, IC, IT
    {
        public override void Handle(TreatmentCase request)
        {
            //request.Lm.has
            var dr = Helper.GetValueAsDateTime(request.Lm?.Element("DR"));
            if (dr == null)
                return;
            var data = Helper.GetValueAsDateTime(request.Zglv.Element("DATA"));

            if (dr > data)
                request.Result.Add(GetInfoOnError(request.Data, $"PERS/DR={dr}>ZGLV/DATA={data}"));
        }
    }
}
