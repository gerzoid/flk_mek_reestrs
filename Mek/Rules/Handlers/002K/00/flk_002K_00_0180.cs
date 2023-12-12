using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0180 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var year = Helper.GetValueAsInt(request.Schet?.Element("YEAR"));
            var month = Helper.GetValueAsInt(request.Schet?.Element("MONTH"));
            var date_z_2 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_2"));
            if (date_z_2 != null)
            {
                if (date_z_2.Value.Year == year)
                    if (date_z_2.Value.Month > month)
                        request.Result.Add(GetInfoOnError(request.Data, $"SCHET/MONTH {month}<{date_z_2.Value.Month}"));
            }
        }
    }

}
