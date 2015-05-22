using System.Collections.Generic;
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
        public void TesteListaVazia()
        {
            var lista = new List<int>();

            Assert.AreEqual(Utils.CheckEmptyList(lista), true);
        }
    }
}
