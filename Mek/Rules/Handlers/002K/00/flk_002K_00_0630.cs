using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0630 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var ds1 = s.Element("DS1").Value;
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
                            if ((code_sh != null) && (string.Compare(ds1, "C81") >= 0 && (string.Compare(ds1, "C97") < 0)))
                                request.Result.Add(GetInfoOnError(request.Data, $"При DS1={ds1} CODE_SH={code_sh} не заполняется"));

                        }
                    }
                }
            }
        }
    }

}
