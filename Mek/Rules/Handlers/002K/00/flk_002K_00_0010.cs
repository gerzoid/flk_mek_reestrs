using mek.Utils;
using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0010 : HandlerFlk, IC, ID, IH, IR, IT, IX, IGlobalRule
    {
        public override void Handle(TreatmentCase request)
        {
            var data = Helper.GetValueAsDateTime(request.Zglv.Element("DATA"));

            if (data > DateTime.Now)
                request.Result.Add(GetInfoOnError(request.Data, $"ZGLV/DATA={data}<{DateTime.Now}"));
        }
    }
}
