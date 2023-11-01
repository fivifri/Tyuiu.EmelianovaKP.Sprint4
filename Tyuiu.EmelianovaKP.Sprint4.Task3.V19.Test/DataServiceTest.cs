using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint4.Task3.V19.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();

            Assert.AreEqual(11, dataService.Calculate(new int[,] { {6, 5, 6, 3, 8}, {9, 4, 4, 3, 4}, {3, 3, 6, 8, 6}, {6, 5, 3, 4, 3}, {9, 3, 5, 3, 7} }));
        }
    }
}
