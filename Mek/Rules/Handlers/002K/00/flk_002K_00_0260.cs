using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0260 : HandlerFlk, ID, IR
    {
        public override void Handle(TreatmentCase request)
        {
            var docnum = request.Data?.Element("PACIENT")?.Element("DOCNUM")?.Value;
            if (docnum == null)
                return;

            var doctype = request.Data?.Element("PACIENT")?.Element("DOCTYPE")?.Value;
            if (doctype == null)
                request.Result.Add(GetInfoOnError(request.Data, $"PACIENT/DOCNUM={docnum} DOCTYPE отсутсвует"));
        }
    }

}
