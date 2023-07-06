using Marauders_Oasis.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marauders_Oasis.Data.Configurations
{
	public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(GenerateCategories());
		}

		private Category[] GenerateCategories()
		{
			return new HashSet<Category>() {

			new Category { Id = 1, Name = "Construction", Description = "Projects related to building and construction work" },
			new Category { Id = 2, Name = "Military", Description = "Projects related to military and defense activities" },
			new Category { Id = 3, Name = "Small Hustle", Description = "Small-scale projects for quick tasks and services" },
			new Category { Id = 4, Name = "Transportation", Description = "Projects related to logistics and transportation services" },
			new Category { Id = 5, Name = "Technology", Description = "Projects related to IT, software development, and technology innovations" },
			new Category { Id = 6, Name = "Healthcare", Description = "Projects related to healthcare services and medical research" },
			new Category { Id = 7, Name = "Education", Description = "Projects related to educational services, tutoring, and academic research" },
			// Add more categories as needed
		 }.ToArray();

		}
	}
}
