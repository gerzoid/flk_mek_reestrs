using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mek.Rules
{
    public abstract class HandlerFlk : IHandler
    {
        public string GetNameClass()
        {
            return this.GetType().Name;
        }

        public abstract void Handle(TreatmentCase request);

        public virtual void Test(TreatmentCase request)
        {
            Console.WriteLine(GetNameClass());
            Handle(request);
        }
        public virtual FlkError GetInfoOnError(XElement doc, string comment = "")
        {
            var err = new FlkError();
            err.n_zap = doc.Element("N_ZAP")?.Value;
            err.id_pac = doc.Element("PACIENT")?.Element("ID_PAC")?.Value;
            err.idcase = doc.Element("Z_SL")?.Element("IDCASE")?.Value;
            err.comment = comment;
            err.id_error = GetNameClass();
            return err;
        }
    }

}
