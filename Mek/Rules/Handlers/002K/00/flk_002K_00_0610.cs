using Mek.Interfaces;
using mek.Utils;

namespace mek.Rules.Handlers
{
    public class flk_002K_00_0610 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Element("Z_SL")?.Elements("SL");
            foreach (var s in sl)
            {
                var date_1 = Helper.GetValueAsDateTime(s.Element("DATE_1"));
                var onk_sl = s.Elements("ONK_SL");
                foreach (var onk_s in onk_sl)
                {
                    var onk_usl = onk_s.Elements("ONK_USL");
                    foreach (var onk_us in onk_usl)
                    {
                        var lek_pr = onk_us.Elements("LEK_PR");
                        foreach (var lek in lek_pr)
                        {
                            var date_inj = lek.Elements("DATE_INJ");
                            foreach (var inj in date_inj)
                            {
                                var date_injection = Helper.GetValueAsDateTime(inj);
                                if (date_injection == null || date_injection < date_1)
                                    request.Result.Add(GetInfoOnError(request.Data, $"DATE_INJ={date_injection} DATE_1={date_1}"));
                            }
                        }
                    }
                }
            }
        }
    }

}
