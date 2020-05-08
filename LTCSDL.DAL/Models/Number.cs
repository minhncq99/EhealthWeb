using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTCSDL.DAL.Models
{
    public class Number
    {
        public int NumberId { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Disease> Diseases { get; set; }
    }
}
