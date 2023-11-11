using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint4.Task6.V7.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();

            Assert.AreEqual(ds.Calculate(new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика"}), 3);
        }
    }
}
