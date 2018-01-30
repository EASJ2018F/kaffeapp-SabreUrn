using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests {
    [TestClass]
    public class FlatWhiteTests {
        [TestMethod]
        public void TestFlatWhite_MlMælk160() {
            //arrange
            FlatWhite flatWhite = new FlatWhite();

            //act
            int expected = 160;
            int actual = flatWhite.MlMælk();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFlatWhite_PrisNotNegative() {
            //arrange
            FlatWhite flatWhite = new FlatWhite();

            //act
            int actual = flatWhite.Pris();

            //assert
            Assert.IsTrue(actual >= 0);
        }

        [TestMethod]
        public void TestFlatWhite_PrisEquals45() {
            //arrange
            FlatWhite flatWhite = new FlatWhite();

            //act
            int expected = 45;
            int actual = flatWhite.Pris();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFlatWhite_StyrkeNotEmptyOrWhitespace() {
            //arrange
            FlatWhite flatWhite = new FlatWhite();

            //act
            string actual = flatWhite.Styrke();

            //assert
            Assert.IsFalse(String.IsNullOrWhiteSpace(actual));
        }

        [TestMethod]
        public void TestFlatWhite_StyrkeEqualsMild() {
            //arrange
            FlatWhite flatWhite = new FlatWhite();

            //act
            string expected = "mild";
            string actual = flatWhite.Styrke();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
