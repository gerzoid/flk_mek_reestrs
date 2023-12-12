using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0310 : HandlerFlk, ID, IR, IH, IC, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var npr_date = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("NPR_DATE"));
            if (npr_date != null)
            {
                var date_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));
                if (npr_date > date_z_1)
                    request.Result.Add(GetInfoOnError(request.Data, $"NPR_DATE={npr_date} > DATE_Z_1={date_z_1}"));
            }

        }
    }

}
