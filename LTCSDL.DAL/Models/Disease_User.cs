namespace LTCSDL.DAL.Models
{
    public class Disease_User
    {
        public bool Saved { get; set; }
        public int DiseaseId { get; set; }
        public int UserId { get; set; }

        public Disease Disease { get; set; }
        public User User { get; set; }
    }
}
