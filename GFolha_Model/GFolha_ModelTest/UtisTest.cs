using System;
using GFolha_Model.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFolha_ModelTest
{
    [TestClass]
    public class UtisTest
    {
       
        [TestMethod]
        public void TesteObjetoPreenchido()
        {
            var obj = new object();

            Assert.AreEqual(Utils.CheckNullObject(obj), false);
        }

        [TestMethod]
        public void TesteConverteStringParaData()
        {
            var data = "20/12/2015";

            Assert.AreEqual(Utils.ConvertStringToDateTime(data), new DateTime(2015,12,20));
        }

        [TestMethod]
        public void TesteConverteStringVaziaParaData()
        {
            var data = string.Empty;

            Assert.AreEqual(Utils.ConvertStringToDateTime(data), DateTime.Now);
        }

        [TestMethod]
        public void TesteEmailValido()
        {
            var email = "teste@teste.com";

            Assert.AreEqual(Utils.ValidateEmail(email), true);
        }

        [TestMethod]
        public void TesteEmailInvalido()
        {
            var email = ".teste@.te**/.";

            Assert.AreNotEqual(Utils.ValidateEmail(email), true);
        }

        [TestMethod]
        public void TesteFormatacaoCpfValida()
        {
            var cpf = "000.000.000-00";

            Assert.AreEqual(Utils.ValidaFormatacaoCpf(cpf), true);
        }

        [TestMethod]
        public void TesteFormatacaoCpfInvalida()
        {
            var cpf = "00000000000";

            Assert.AreEqual(Utils.ValidaFormatacaoCpf(cpf), false);
        }

        [TestMethod]
        public void TesteFormatacaoCnpjValida()
        {
            var cnpj = "00.000.000/0000-00";

            Assert.AreEqual(Utils.ValidaFormatacaoCnpj(cnpj), true);
        }

        [TestMethod]
        public void TesteFormacataoCnpjInvalida()
        {
            var cnpj = "000";

            Assert.AreNotEqual(Utils.ValidaFormatacaoCnpj(cnpj), true);
        }

        [TestMethod]
        public void TesteCpfValido()
        {
            var cpf = "60372778267";

            Assert.AreEqual(Utils.ChecaSeCpfValido(cpf), true);
        }

        [TestMethod]
        public void TesteCpfInValido()
        {
            var cpf = "000";

            Assert.AreEqual(Utils.ChecaSeCpfValido(cpf), false);
        }
    }
}
