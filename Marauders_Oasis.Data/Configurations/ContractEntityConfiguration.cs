using Marauders_Oasis.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Marauders_Oasis.Data.Configurations
{
	public class ContractEntityConfiguration : IEntityTypeConfiguration<Contract>
	{
		public void Configure(EntityTypeBuilder<Contract> builder)
		{
			builder.HasOne(contract => contract.Category)            //done
				.WithMany(category => category.Contracts)
				.HasForeignKey(contract => contract.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(contract => contract.Contractor)          //done
				.WithMany(contractor => contractor.OwnedContracts)
				.HasForeignKey(contract => contract.ContractorId)
				.OnDelete(DeleteBehavior.Restrict);



			//builder.HasOne(contract => contract.Executor)     
			//	.WithMany(executor => executor.AdoptedContracts)
			//	.HasForeignKey(contract => contract.ExecutorId)
			//	.OnDelete(DeleteBehavior.Restrict);

			//Executor should be able to be deleted, according to GDPR, so I remove the block above


			builder.HasData(GenerateContracts());
		}

		public Contract[] GenerateContracts()
		{
			return new HashSet<Contract>() {

				new Contract
		{
			Id = Guid.NewGuid(),
			Title = "Build a Residential House",
			Location = "New York, NY",
			Description = "Looking for a contractor to build a 3-bedroom residential house.",
			Price = 250000m,
			Status = "Active",
			DatePosted = DateTime.Now.AddDays(-10),
			CategoryId = 1, // Construction
            ContractorId = Guid.Parse("B6D43B2D-875B-4F50-A204-491FA8C5D740"),
			ExecutorId = Guid.Parse("F54F0AD3-04D8-4006-5C3C-08DB7D698196")
		},
		new Contract
		{
			Id = Guid.NewGuid(),
			Title = "Military Equipment Maintenance",
			Location = "Washington, DC",
			Description = "Need a contractor for regular maintenance of military equipment.",
			Price = 50000m,
			Status = "Active",
			DatePosted = DateTime.Now.AddDays(-20),
			CategoryId = 2, // Military
            ContractorId = Guid.Parse("B6D43B2D-875B-4F50-A204-491FA8C5D740"),
			ExecutorId = Guid.Parse("F54F0AD3-04D8-4006-5C3C-08DB7D698196")
		},
		new Contract
		{
			Id = Guid.NewGuid(),
			Title = "Website Development",
			Location = "Remote",
			Description = "Need a contractor to develop a new website for our business.",
			Price = 5000m,
			Status = "Active",
			DatePosted = DateTime.Now.AddDays(-15),
			CategoryId = 5, // Technology
            ContractorId = Guid.Parse("B6D43B2D-875B-4F50-A204-491FA8C5D740"),
			ExecutorId = Guid.Parse("F54F0AD3-04D8-4006-5C3C-08DB7D698196")


		}
			}.ToArray();

		}
	}
}
