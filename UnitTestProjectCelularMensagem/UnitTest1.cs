using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestProjectCelularMensagem.Celular;

namespace UnitTestProjectCelularMensagem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExemploFrase()
        {
            string msg = "77773367_7773302_222337777_777766606660366656667889999_9999555337777";
            Assert.AreEqual(msg, new Mensagem("SEMPRE ACESSO O DOJOPUZZLES").str_saida);
        }

        [TestMethod]
        public void ExemploDeValoresComMesmaSaida()
        {
            string msg = "2_22_222";
            Assert.AreEqual(msg, new Mensagem("ABC").str_saida);
        }

        [TestMethod]
        public void ExemploDeValoresComMesmaSaidaLetraMinuscula()
        {
            string msg = "2_22_222";
            Assert.AreEqual(msg, new Mensagem("abc").str_saida);
        }

    }
}
