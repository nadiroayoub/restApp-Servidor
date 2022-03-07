using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InitializeDB;

namespace UnitTestConx
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateDb()
        {
            try
            {
                InitializeDB.CreateDB.Create("","","");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

    }
}
