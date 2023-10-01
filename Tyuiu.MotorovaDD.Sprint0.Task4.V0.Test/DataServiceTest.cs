using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MotorovaDD.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckedAdditionValid()

        {
            Assert.AreEqual(10,DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedAdditionValid()

        {
            Assert.AreEqual(5, DataService.Subration(10, 5));
        }

        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedAdditionValid()
        {
          Assert.AreEqual(3, DataService.Division(10, 5));
        }
    }
}
