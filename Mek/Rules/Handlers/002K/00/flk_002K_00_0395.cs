using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0395 : HandlerFlk, IC, ID, IH, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var date_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var det = Helper.GetValueAsInt(s.Element("DET"));
                if (det == 1)
                {
                    var dbirth = Helper.GetValueAsDateTime(request.Lm.Element("DR"));
                    if (Helper.GetYearsDifference(dbirth.Value, date_z_1.Value) >= 18)
                        request.Result.Add(GetInfoOnError(request.Data, $"DET={det} DATE_Z_1={date_z_1} DBIRTH={dbirth} >=18 лет"));
                }
            }

        }
    }

}
