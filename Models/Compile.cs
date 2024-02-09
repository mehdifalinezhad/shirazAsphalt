namespace OtherWise.Models
{
    public class Compile
    {
        public Guid Id { get; set; } 
        public string description { get; set; }
        public string Object { get; set; }
    
        public Guid UserId { get; set; }
        public User user { get; set; }
    }
}