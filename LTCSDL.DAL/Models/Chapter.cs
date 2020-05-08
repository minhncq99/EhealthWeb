using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTCSDL.DAL.Models
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
