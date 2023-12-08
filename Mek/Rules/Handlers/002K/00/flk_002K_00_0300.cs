using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0300 : HandlerFlk, ID, IR, IH, IC, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var npr_mo = request.Data?.Element("Z_SL")?.Element("NPR_MO");
            if (npr_mo == null)
                return;

            var npr_date = request.Data?.Element("Z_SL")?.Element("NPR_DATE");
            if (npr_date == null)
                request.Result.Add(GetInfoOnError(request.Data, $"NPR_DATE={npr_date} отсутствует NPR_MO"));
        }
    }

}
