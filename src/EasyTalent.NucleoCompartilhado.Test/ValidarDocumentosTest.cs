using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyTalent.NucleoCompartilhado.Test
{
    [TestClass]
    public class ValidarDocumentosTest
    {
        [TestMethod]
        public void ValidarEmail()
        {
            Assert.AreEqual(true, ValidarDocumentos.ValidarEmail("augustoccp@gmail.com"));
        }

        [TestMethod]
        public void ValidarEmailInvalido()
        {
            Assert.AreEqual(false, ValidarDocumentos.ValidarEmail("augustoccp.k.comm"));
        }


    }
}