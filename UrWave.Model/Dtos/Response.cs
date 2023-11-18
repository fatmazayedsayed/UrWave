using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrWave.Model.Dtos
{
    public class Response
    {
        public class PaginationInfo
        {
            public int totalCount { get; set; }
            public int take { get; set; }
            public int skip { get; set; }
        }

        public class Root<T>
        {
            public object status { get; set; }
            public List<T> result { get; set; }
            public PaginationInfo paginationInfo { get; set; }
        }


    }
}
