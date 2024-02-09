using System.Net.Http.Headers;

namespace OtherWise.Models
{
    public class AboutUs
    {
      public Guid Id { get; set; }
        public string OurCopany { get; set;}
        public string Discription { get; set;}
        public string Address { get; set; }
        Rezume rezume { get; set;}
        Guid  RezumeId { get; set;}
    }
}
