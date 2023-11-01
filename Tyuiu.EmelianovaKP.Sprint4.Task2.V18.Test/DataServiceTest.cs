using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint4.Task2.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();

            Assert.AreEqual(384, dataService.Calculate(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}));
        }
    }
}
