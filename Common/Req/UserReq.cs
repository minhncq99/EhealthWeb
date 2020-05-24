using System.Runtime.Intrinsics.X86;

namespace LTCSDL.Common.Req
{
    public class UserReq
    {
        public int UserId { get; set; }
        
        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Job { get; set; }
        
        public int TypeUser { get; set; }
    }
}
