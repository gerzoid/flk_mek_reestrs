using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers
{
    public class flk_002K_00_0650 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            var dbirth = Helper.GetValueAsDateTime(request.Lm.Element("DR"));
            var date_z_1 = Helper.GetValueAsDateTime(request.Data?.Element("Z_SL")?.Element("DATE_Z_1"));
            if (Helper.GetYearsDifference(dbirth.Value, date_z_1.Value) < 18)
                return;

            foreach (var s in sl)
            {
                var ds1 = s.Element("DS1").Value;

                bool condition1 = string.Compare(ds1, "C00.0") >= 0 && string.Compare(ds1, "C81.0") < 0;
                bool condition2 = string.Compare(ds1, "C97") >= 0 && string.Compare(ds1, "D10") < 0;
                if (!condition1 && !condition2)
                    return;

                var onk_sl = s.Elements("ONK_SL");
                foreach (var onk_s in onk_sl)
                {
                    var onk_usl = onk_s.Elements("ONK_USL");
                    foreach (var onk_us in onk_usl)
                    {
                        var usl_tip = Helper.GetValueAsInt(onk_us.Element("USL_TIP"));
                        if (usl_tip != 2)
                            return;

                        var lek_pr = onk_us.Elements("LEK_PR");
                        foreach (var lek in lek_pr)
                        {
                            var code_sh = lek.Element("CODE_SH")?.Value;
                            bool cond = string.Compare(code_sh, "sh001") >= 0 && string.Compare(code_sh, "sh904") <= 0;

                            if (!cond)
                                request.Result.Add(GetInfoOnError(request.Data, $"USL_TIP={usl_tip} DBIRTH={dbirth} DS1={ds1} ошибка в CODE_SH={code_sh} "));
                        }
                    }
                }
            }
        }
    }
}
