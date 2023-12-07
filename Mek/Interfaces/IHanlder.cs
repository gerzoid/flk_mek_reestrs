using mek.Rules;

namespace Mek.Interfaces
{
    //Правило обработки
    public interface IHandler
    {
        public void Handle(TreatmentCase request);
        public void Test(TreatmentCase request);
    }

}
