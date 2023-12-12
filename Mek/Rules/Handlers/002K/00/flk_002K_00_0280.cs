using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules.Handlers._002K._00
{
    public class flk_002K_00_0280 : HandlerFlk, ID, IR
    {
        public override void Handle(TreatmentCase request)
        {
            var docnum = request.Data?.Element("PACIENT")?.Element("DOCNUM")?.Value;
            if (docnum == null)
                return;

            var docorg = request.Data?.Element("PACIENT")?.Element("DOCORG")?.Value;
            if (docorg == null)
                request.Result.Add(GetInfoOnError(request.Data, $"PACIENT/DOCNUM={docnum} DOCORG отсутсвует"));
        }
    }

}
