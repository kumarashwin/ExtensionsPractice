using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsPractice.ReferenceDataSource
{
    public static class IReferenceDataSourceCollectionExtensions
    {
        public static IEnumerable<ReferenceDataItem>GetAllItemsByCode(
            this IEnumerable<IReferenceDataSource> sources,
            string code)
        {
            return sources
                .SelectMany(source => source.GetItemsByCode(code));

            //var items = new List<ReferenceDataItem>();
            //foreach(var source in sources)
            //{
            //    items.AddRange(source.GetItemsByCode(code));
            //}
            //return items;
        }
    }
}
