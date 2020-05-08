using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTCSDL.DAL.Models
{
    public class User
    {
        public int UserId { get; set; }
        
        [MaxLength(200)]
        public string FullName { get; set; }

        [MaxLength(200)]
        public string UserName { get; set; }

        [MaxLength(20)]
        [MinLength(6)]
        public string Password { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Job { get; set; }
        public int TypeUser { get; set; }

        public ICollection<Disease_User> Diseases_Users { get; set; }
    }
}
