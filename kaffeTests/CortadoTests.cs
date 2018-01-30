using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests {
    [TestClass]
    public class CortadoTests {
        [TestMethod]
        public void TestCortado_MlMælkEquals25() {
            //arrange
            Cortado cortado = new Cortado();

            //act
            int expected = 25;
            int actual = cortado.MlMælk();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCortado_PrisNotNegative() {
            //arrange
            Cortado cortado = new Cortado();

            //act
            int actual = cortado.Pris();

            //assert
            Assert.IsTrue(actual >= 0);
        }

        [TestMethod]
        public void TestCortado_PrisEquals25() {
            //arrange
            Cortado cortado = new Cortado();

            //act
            int expected = 25;
            int actual = cortado.Pris();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
