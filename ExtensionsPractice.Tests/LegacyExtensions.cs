using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionsPractice;

namespace ExtensionsPractice.Tests
{
    [TestClass]
    public class LegacyExtensions
    {
        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 13);

            Assert.AreEqual("0201213", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);

            Assert.AreEqual("1131031", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormatName()
        {
            var name = "Elton Stoneman";
            Assert.AreEqual("STONEMAN, ELTON", name.ToLegacyFormat());
        }
    }


}
