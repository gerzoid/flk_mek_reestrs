using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0160 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var year = Helper.GetValueAsInt(request.Schet?.Element("YEAR"));
            var date_z_2 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_2"));
            if (date_z_2 != null)
            {
                if (date_z_2.Value.Year > year)
                    request.Result.Add(GetInfoOnError(request.Data, $"SCHET/YEAR {year}<{date_z_2.Value.Year}"));
            }
        }
    }
}
