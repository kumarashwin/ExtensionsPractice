using System.Xml;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsPractice.Tests
{
    [TestClass]
    public class DateTimeExtensions
    {
        [TestMethod]
        public void ToXmlDateTime()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951Z", dateTime.ToXmlDataTime());
        }

        [TestMethod]
        public void ToXmlDateTime_Local()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951-04:00", dateTime.ToXmlDataTime(XmlDateTimeSerializationMode.Local));

        }
    }
}
