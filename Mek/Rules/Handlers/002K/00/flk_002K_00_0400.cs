using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0400 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var date_z_1 = request.Data?.Element("Z_SL")?.Element("DATE_Z_1")?.Value;
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var x in sl)
            {
                if (Convert.ToDateTime(date_z_1) > Convert.ToDateTime(x.Element("DATE_1").Value))
                {
                    request.Result.Add(GetInfoOnError(request.Data, $"{x.Element("DATE_1").Value}>{date_z_1}"));
                }
            }
        }
    }
}
