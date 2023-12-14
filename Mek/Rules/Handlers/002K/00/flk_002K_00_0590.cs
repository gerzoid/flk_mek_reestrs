using Mek.Interfaces;
using mek.Utils;

namespace mek.Rules.Handlers
{
    public class flk_002K_00_0590 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var napr = s.Elements("NAPR");
                foreach (var n in napr)
                {
                    var napr_date = Helper.GetValueAsDateTime(n.Element("NAPR_DATE"));
                    var date_1 = Helper.GetValueAsDateTime(s.Element("DATE_1"));
                    if ((napr_date == null) || (napr_date < date_1))
                        request.Result.Add(GetInfoOnError(request.Data, $"NAPR_DATE={napr_date} < DATE_1={date_1}"));
                }
            }
        }
    }
}
