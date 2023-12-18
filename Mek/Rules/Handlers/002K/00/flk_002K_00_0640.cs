using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0640 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            var dbirth = Helper.GetValueAsDateTime(request.Lm.Element("DR"));
            var date_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));
            if (Helper.GetYearsDifference(dbirth.Value, date_z_1.Value) >= 18)
                return;

            foreach (var s in sl)
            {
                var onk_sl = s.Elements("ONK_SL");
                foreach (var onk_s in onk_sl)
                {
                    var onk_usl = onk_s.Elements("ONK_USL");
                    foreach (var onk_us in onk_usl)
                    {
                        var lek_pr = onk_us.Elements("LEK_PR");
                        foreach (var lek in lek_pr)
                        {
                            var code_sh = lek.Element("CODE_SH")?.Value;
                            if (code_sh != null)
                                request.Result.Add(GetInfoOnError(request.Data, $"Возраст DBIRTH={dbirth} CODE_SH={code_sh} не заполняется"));
                        }
                    }
                }
            }
        }
    }

}
