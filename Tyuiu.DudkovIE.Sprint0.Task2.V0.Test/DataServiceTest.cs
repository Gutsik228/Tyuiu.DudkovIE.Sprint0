using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DudkovIE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Игорь", res);
        }
            
        
    }
}
