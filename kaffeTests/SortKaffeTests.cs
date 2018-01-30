using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class SortKaffeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat20kr()
        {
            //Arrange
            var sortKaffe = new SortKaffe(20);

            //Act
            int pris = sortKaffe.Pris();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat21kr()
        {
            //Arrange
            var sortKaffe = new SortKaffe(21);

            //Act
            int pris = sortKaffe.Pris();
        }

        /// <summary>
        /// Rabatten skal være 0 når default ctor kaldes
        /// </summary>
        [TestMethod]
        public void SortKaffeDefaultConstructorRabat()
        {
            //Arrange
            var sortKaffe = new SortKaffe();

            //Act
            sortKaffe.Styrke();

            //Assert
            Assert.AreEqual(sortKaffe.Rabat, 0);

        }

        [TestMethod]
        public void TestSortKaffe_PrisWithRabatLessThan20() {
            //arrange
            SortKaffe sortKaffe = new SortKaffe(10);

            //act
            int expected = 10;
            int actual = sortKaffe.Pris();

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}