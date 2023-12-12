using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0340 : HandlerFlk, IC, ID, IH, IR, IT, IX
    {
        public override void Handle(TreatmentCase request)
        {
            var dschet = request.Schet.Element("DSCHET")?.Value;
            var date_z_2 = request.Data?.Element("Z_SL")?.Element("DATE_Z_2")?.Value;
            if ((Convert.ToDateTime(date_z_2)) > Convert.ToDateTime(dschet))
            {
                request.Result.Add(GetInfoOnError(request.Data, $"DATE_Z_2 ={date_z_2}>DSCHET={dschet}"));
            }
        }
    }

}
