using System.ComponentModel.DataAnnotations;
using static Marauders_Oasis.Common.EntityValidationConstants.Category;

namespace Marauders_Oasis.Data.Models.Models
{
	public class Category
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		[MinLength(NameMinLength)]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MinLength(DescriptionMinLength)]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		//could be null
		//collection of contracts for this category
		public ICollection<Contract>? Contracts { get; set; } = new List<Contract>();
	}
}
