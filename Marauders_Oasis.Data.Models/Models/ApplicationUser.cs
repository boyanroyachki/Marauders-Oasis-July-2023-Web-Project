using Microsoft.AspNetCore.Identity;

namespace Marauders_Oasis.Data.Models.Models
{
	public class ApplicationUser : IdentityUser<Guid>
	{
		public ApplicationUser()
		{
			this.Id = new Guid();
			AdoptedContracts = new HashSet<Contract>();
		}
		public virtual ICollection<Contract> AdoptedContracts { get; set; } //adopted contracts
	}
}
