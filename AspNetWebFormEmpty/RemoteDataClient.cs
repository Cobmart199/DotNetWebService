using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetWebFormEmpty
{
    [Serializable]
    public class MyRemoteDataClient
    {
        public String dayOfWeek { get; set; }
        public bool isUrlProvided { get; set; }
        public DateTime mydateTime { get; set; }
    }
}