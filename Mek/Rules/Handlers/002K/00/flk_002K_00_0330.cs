using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0330 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var date_z_1 = request.Data?.Element("Z_SL")?.Element("DATE_Z_1")?.Value;
            var date_z_2 = request.Data?.Element("Z_SL")?.Element("DATE_Z_2")?.Value;
            if ((Convert.ToDateTime(date_z_1)) > Convert.ToDateTime(date_z_2))
            {
                request.Result.Add(GetInfoOnError(request.Data, $"DATE_Z1={date_z_1} > DATE_Z_2={date_z_2}"));
            }
        }
    }

}
