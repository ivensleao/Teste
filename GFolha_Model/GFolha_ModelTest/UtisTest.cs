using System;
using GFolha_Model.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFolha_ModelTest
{
    [TestClass]
    public class UtisTest
    {
        [TestMethod]
        public void TesteObjetoNull()
        {
            //Assert.AreNotEqual(Utils.CheckNullObject(null), true);
        }

        [TestMethod]
        public void TesteObjetoPreenchido()
        {
            var obj = new object();

            Assert.AreEqual(Utils.CheckNullObject(obj), false);
        }
    }
}
