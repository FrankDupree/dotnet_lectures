namespace Daniel.Models
{
    public class UserProfile
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public string country { get; set; }
        public string tribe { get; set; }
    }
}
