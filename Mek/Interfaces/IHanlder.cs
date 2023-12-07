using Mek.ChainOfResponsibility;
using Mek.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mek.Interfaces
{
    //Правило обработки
    public interface IHandler
    {
        public void HandleAsync(TreatmentCase request);
        public void Test(TreatmentCase request);
    }

}
