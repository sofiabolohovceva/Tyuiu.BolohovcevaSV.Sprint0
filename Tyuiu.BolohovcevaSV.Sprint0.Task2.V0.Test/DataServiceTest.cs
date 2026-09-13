using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BolohovcevaSV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BolohovcevaSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "София";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, София", res);
        }
    }
}
