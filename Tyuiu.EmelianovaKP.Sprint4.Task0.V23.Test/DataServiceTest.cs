using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint4.Task0.V23.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            var dataService = new DataService();

            Assert.AreEqual(99225, dataService.GetMultOddArrEl(new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7}));
        }
    }
}
