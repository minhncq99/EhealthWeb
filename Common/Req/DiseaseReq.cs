using System;
using System.Collections.Generic;
using System.Text;

namespace LTCSDL.Common.Req
{
    public class DiseaseReq
    {
        public int DiseaseId { get; set; }
        public string EnglishName { get; set; }
        public string VietnameseName { get; set; }
        public string Symptom { get; set; }
        public int NumberId { get; set; }
    }
}
