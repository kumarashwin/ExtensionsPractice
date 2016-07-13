using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using ExtensionsPractice.ReferenceDataSource.Extensions;
using ExtensionsPractice.ReferenceDataSource;
using System.Collections.Generic;
using ExtensionsPractice.ReferenceDataSource.Implementations;

namespace ExtensionsPractice.Tests
{
    [TestClass]
    public class ObjectExtensions
    {
        [TestMethod]
        public void ToJsonString()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine($"obj1 - {obj1.ToJsonString()}");

            var obj2 = new DateTime(2000,12,31);
            Debug.WriteLine($"obj2 - {obj2.ToJsonString()}");

            var obj3 = new ReferenceDataItem { Code = "xyz", Description = "123"};
            Debug.WriteLine($"obj3 - {obj3.ToJsonString()}");

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource>{
                new SqlReferenceDataSource() };
            Debug.WriteLine($"obj4 - {obj4.ToJsonString()}");
        }

        [TestMethod]
        public void GetJsonTypeDescriptions()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine($"obj1 - {obj1.GetJsonTypeDescription()}");

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine($"obj2 - {obj2.GetJsonTypeDescription()}");

            var obj3 = new ReferenceDataItem { Code = "xyz", Description = "123" };
            Debug.WriteLine($"obj3 - {obj3.GetJsonTypeDescription()}");

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource>{
                new SqlReferenceDataSource() };
            Debug.WriteLine($"obj4 - {obj4.GetJsonTypeDescription()}");
        }
    }
}
