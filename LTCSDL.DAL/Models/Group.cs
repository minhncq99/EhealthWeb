using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTCSDL.DAL.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }

        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }

        public ICollection<Number> Numbers { get; set; }
    }
}
