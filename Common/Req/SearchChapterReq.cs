using System;
using System.Collections.Generic;
using System.Text;

namespace LTCSDL.Common.Req
{
    public class SearchChapterReq
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string Keyword { get; set; }
    }
}
