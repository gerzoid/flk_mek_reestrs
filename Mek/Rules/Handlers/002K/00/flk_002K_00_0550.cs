using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers
{
    public class flk_002K_00_0550 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var usl = s.Elements("USL");
                foreach (var us in usl)
                {
                    var date_in = Helper.GetValueAsDateTime(us?.Element("DATE_IN"));
                    var date_out = Helper.GetValueAsDateTime(us?.Element("DATE_OUT"));
                    if (date_in > date_out)
                        request.Result.Add(GetInfoOnError(request.Data, $"DATE_IN={date_in} > DATE_OUT={date_out}"));
                }
            }
        }
    }

}
