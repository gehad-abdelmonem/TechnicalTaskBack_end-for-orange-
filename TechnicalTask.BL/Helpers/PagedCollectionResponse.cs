using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTask.BL.Helpers
{
    public class PagedCollectionResponse<T> where T: class
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public List<T> Data { get; set; }

    }
}
