using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0570 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var usl = s.Elements("USL");
                foreach (var e in usl)
                {
                    var tarif = Helper.GetValueAsDecimal(e.Element("TARIF"));
                    var sumv_usl = Helper.GetValueAsDecimal(e.Element("SUMV_USL"));
                    if (tarif > sumv_usl)
                        request.Result.Add(GetInfoOnError(request.Data, $"TARIF={tarif} > SUMV_USL={sumv_usl}"));
                }
            }
        }
    }

}
