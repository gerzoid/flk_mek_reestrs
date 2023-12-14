using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0530 : HandlerFlk, IC, IH, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var date1 = Helper.GetValueAsDateTime(s?.Element("DATE_1"));
                var usl = s.Elements("USL");
                foreach (var e in usl)
                {
                    var date_in = Helper.GetValueAsDateTime(e?.Element("DATE_IN"));

                    if (date_in < date1)
                        request.Result.Add(GetInfoOnError(request.Data, $"DATE_IN={date_in} < DATE_1={date1}"));
                }
            }

        }
    }

}
