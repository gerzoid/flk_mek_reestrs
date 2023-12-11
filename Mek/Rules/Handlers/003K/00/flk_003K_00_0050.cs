using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers
{
    public class flk_003K_00_0050 : HandlerFlk, IX
    {
        //TODO
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var disp = s.Element("DISP")?.Value;
                if ((disp == "ДВ2") || (disp == "ДВ4") || (disp == "ОПВ"))
                {
                    var dbirth = Helper.GetValueAsDateTime(request.Lm.Element("DR"));
                    var date_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));
                    if (Helper.GetYearsDifference(dbirth.Value, date_z_1.Value) < 18)
                        request.Result.Add(GetInfoOnError(request.Data, $"DISP={disp} DBIRTH={dbirth} - date_z_1={date_z_1} < 18 лет"));
                }
            }
        }
    }

}
