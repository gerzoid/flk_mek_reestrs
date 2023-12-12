using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0200 : HandlerFlk, IC, ID, IH, IR, IT, IX, IGlobalRule
    {
        public override void Handle(TreatmentCase request)
        {
            var data = Helper.GetValueAsDateTime(request.Zglv.Element("DATA"));
            var dschet = Helper.GetValueAsDateTime(request.Schet.Element("DSCHET"));

            if (dschet > data)
                request.Result.Add(GetInfoOnError(request.Data, $"DSCHET={dschet}>ZGLV/DATA={data}"));
        }
    }
}
