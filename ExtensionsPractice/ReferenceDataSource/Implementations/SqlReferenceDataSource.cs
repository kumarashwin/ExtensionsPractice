using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsPractice.ReferenceDataSource.Implementations
{
    public abstract class SqlDataSource
    {
        public string name = "SQL";
    }

    public class SqlReferenceDataSource : SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem> {
                new ReferenceDataItem { Code = "xyz", Description = "from SQL" },
                new ReferenceDataItem { Code = "xyz", Description = "from SQL2" },};
        }
    }
}
