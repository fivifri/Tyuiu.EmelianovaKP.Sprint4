using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint4.Task7.V21.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();

            Assert.AreEqual(ds.Calculate(4, 3, "425963128528"), 32);
        }
    }
}
