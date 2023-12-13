using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0420 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var date_z_2 = request.Data?.Element("Z_SL")?.Element("DATE_Z_2")?.Value;
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var x in sl)
            {
                if (Convert.ToDateTime(date_z_2) < Convert.ToDateTime(x.Element("DATE_2").Value))
                {
                    request.Result.Add(GetInfoOnError(request.Data, $"DATE_2={x.Element("DATE_2").Value} > DATE_Z_2={date_z_2}"));
                }
            }
        }
    }
}
