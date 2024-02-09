using OtherWise.Models;
using System.Globalization;

namespace OtherWise.Dto
{
    public class CompileDto
    {
        public Guid Id { get; set; }
        public string description { get; set; }
        public string Object { get; set; } 
        public Guid UserId { get; set; }
        public UserDto user { get; set; }
    }
}
