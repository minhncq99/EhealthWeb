using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTCSDL.DAL.Models
{
    public class Disease
    {
        public int DiseaseId { get; set; }

        [MaxLength(200)]
        public string EnglishName { get; set; }

        [MaxLength(200)]
        public string VietnameseName { get; set; }
        public string Symptom { get; set; }
        public int NumberId { get; set; }

        public Number Number { get; set; }
        public ICollection<Disease_User> Diseases_Users { get; set; }
    }
}
