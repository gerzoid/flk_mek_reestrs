using Mek.Interfaces;
using mek.Utils;
using System.Xml.Linq;

namespace mek.Rules.Handlers
{
    public class flk_002K_00_0620 : HandlerFlk, IC, ID, IR, IT
    {
        public override void Handle(TreatmentCase request)
        {
            var sl = request.Data?.Descendants("SL").ToList();
            var onk_usl = sl.SelectMany(s => s.Descendants("ONK_SL").Elements("ONK_USL")).ToList();
            var lek_pr = onk_usl.SelectMany(onk_us => onk_us.Elements("LEK_PR")).ToList();
            var date_inj = lek_pr.SelectMany(lek => lek.Elements("DATE_INJ")).ToList();

            var date_2 = Helper.GetValueAsDateTime(sl.FirstOrDefault()?.Element("DATE_2"));

            var errors = date_inj
                .Select(inj => Helper.GetValueAsDateTime(inj))
                .Where(date_injection => date_injection == null || date_injection > date_2)
                .Select(date_injection => GetInfoOnError(request.Data, $"DATE_INJ={date_injection} DATE_2={date_2}"))
                .ToList();

            request.Result.AddRange(errors);
   }
    }
}
