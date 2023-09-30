using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MotorovaDD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DateServiceTest
    {
        [TestMethod]
        public void CheckGetMessagaValid()
        {
            // Област создания методов тестирования,методов из библиотеки
            var name = "Дана";
            var res = DataService.GetMessage(name);
            // Вызываем класс Assert и метод AreEqual
            Assert AreEqual("Привет, Дана", res) ; 

        }
    }
}
