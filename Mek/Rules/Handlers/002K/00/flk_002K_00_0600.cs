using Mek.Interfaces;
using mek.Utils;

namespace mek.Rules.Handlers
{
    public class flk_002K_00_0600 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var cons = s.Elements("CONS");
                var date_2 = Helper.GetValueAsDateTime(s.Element("DATE_2"));
                foreach (var c in cons)
                {
                    var pr_cons = Helper.GetValueAsInt(c.Element("PR_CONS"));
                    var dt_cons = Helper.GetValueAsDateTime(c.Element("DT_CONS"));
                    if ((pr_cons == 1 || pr_cons == 2 || pr_cons == 3) || (dt_cons != null))
                    {
                        if (dt_cons > date_2)
                            request.Result.Add(GetInfoOnError(request.Data, $"DT_CONS={dt_cons} DATE_2={date_2}"));
                    }
                }
            }
        }
    }

}
