using Mek.Interfaces;
using mek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0560 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var date_2 = Helper.GetValueAsDateTime(s.Element("DATE_2"));
                if (s.Descendants().Where(d => Helper.GetValueAsDateTime(d.Element("DATE_OUT")) > date_2).Count() > 0)
                {
                    var date_out = s.Descendants().Where(d => Helper.GetValueAsDateTime(d.Element("DATE_OUT")) > date_2).Select(d => d.Element("DATE_OUT").Value);
                    foreach (var d in date_out)
                        request.Result.Add(GetInfoOnError(request.Data, $"DATE_OUT={d} > DATE_2={date_2}"));
                }
            }
        }
    }

}
