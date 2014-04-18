using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FackesSampleApplication;

namespace UnitTestProject
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            PrivateObject pbObj = new PrivateObject(p);
            String text = pbObj.Invoke("GetString") as String;
            Assert.AreEqual("hoga", text);

        }
    }
}
