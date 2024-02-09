using System.Security.Cryptography.X509Certificates;

namespace OtherWise.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Price { get; set; }
        public string picUrl{ get; set; }
        public string Mountatain{ get; set; }
        
    }
}
