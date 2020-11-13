using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPratica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarIdadeMaior18()
        {
            int idade = 18;
            bool resultado = Helper.VerificaIdadeDeRisco(idade);
            Assert.IsTrue(resultado);
        }
    }
   
    [TestMethod]
    public void TestarNomeRiso()
    {
        string nome = "Doni";
        bool resultado = Helper.VerificaNomeDeRisco(nome);
        Assert.IsTrue(resultado);
    }
}
}
