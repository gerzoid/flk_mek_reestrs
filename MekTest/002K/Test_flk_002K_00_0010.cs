using mek.Flk;
using mek.Rules;
using mek.Rules.Handlers;
using Xunit;

namespace MekTest._002K
{
    public class Test_flk_002K_00_0010
    {
        public Type fl = typeof(flk_002K_00_0010);

        [Fact]
        public void TestIncorrectValue()
        {
            var treatmentCase = Reestr.OpenXmlSample(TYPE_REESTR.X);
            var data = treatmentCase.Zglv.Element("DATA");
            data.SetValue("2050-03-03");

            var flk = Activator.CreateInstance(fl);
            ((HandlerFlk)flk).Handle(treatmentCase);

            Assert.NotEmpty(treatmentCase.Result);
            Assert.Equal(treatmentCase?.Result?[0].id_error, flk.GetType().Name);
        }

        [Fact]
        public void TestCorrectValue()
        {
            var treatmentCase = Reestr.OpenXmlSample(TYPE_REESTR.X);

            var flk = Activator.CreateInstance(fl);
            ((HandlerFlk)flk).Handle(treatmentCase);

            Assert.Empty(treatmentCase.Result);

        }
    }

}
