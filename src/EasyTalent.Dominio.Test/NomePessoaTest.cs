using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyTalent.Dominio.Test
{
    [TestClass]
    public class NomePessoaTest
    {
        [TestMethod]
        public void NomeCompletoCom3SobreNomes()
        {
            NomePessoa nome = new NomePessoa("AUGUSTO", "CORDEIRO CORREA PINTO");

            Assert.AreEqual("AUGUSTO CORDEIRO CORREA PINTO", nome.NomeCompleto);
        }

        [TestMethod]
        public void IniciaisApartirDoNomeCom3SobreNomes()
        {
            NomePessoa nome = new NomePessoa("AUGUSTO", "CORDEIRO CORREA PINTO");
            Assert.AreEqual("AP", nome.Iniciais);
        }

        [TestMethod]
        public void IniciaisApartirDoNomeSemSobrenome()
        {
            NomePessoa nome = new NomePessoa("AUGUSTO", "");
            Assert.AreEqual("A", nome.Iniciais);
        }
    }
}
