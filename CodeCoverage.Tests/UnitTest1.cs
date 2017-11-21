using CodeCoverage;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCoverage.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod()]
        public void ConstructNameTest()
        {
            CodeCoverage.Models.Contact contact = new Models.Contact();
            contact.firstName = string.Empty;
            contact.lastName = "narayanan";
            contact.ConstructName(contact);
            Assert.AreEqual(null, contact.fullName);
        }
    }
}
