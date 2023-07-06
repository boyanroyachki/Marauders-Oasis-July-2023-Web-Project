using System.ComponentModel.DataAnnotations;
using static Marauders_Oasis.Common.EntityValidationConstants.Contractor;

namespace Marauders_Oasis.Data.Models.Models
{
	public class Contractor
	{
		public Contractor()
		{
			Id = new Guid();
		}

		[Key]
		[Required]
		public Guid Id { get; set; }

		[Required]
		[MinLength(UsernameMinLength)]
		[MaxLength(UsernameMaxLength)]
		public string Username { get; set; } = null!;

		[Required]
		[MinLength(PhoneNumberMinLength)]
		[MaxLength(PhoneNumberMaxLength)]
		public string PhoneNumber { get; set; } = null!;

		[Required]
		public Guid UserId { get; set; }

		public ApplicationUser User { get; set; } = null!;

		public virtual ICollection<Contract> OwnedContracts { get; set; } = new HashSet<Contract>();
	}
}
