using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Operations;

namespace OtherWise.Models
{ 
	public class User : IdentityUser<Guid>
	{
		public User()
		{
			Active = true;
		}
		public bool Active { get; set; }
	}
}
