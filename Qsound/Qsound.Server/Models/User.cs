namespace Qsound.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? SubscriptionType { get; set; }
        public List<Project> Projects { get; set; }

    }
}
