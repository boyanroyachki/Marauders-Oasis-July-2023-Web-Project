using Marauders_Oasis.Data.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Marauder_s_Oasis.Data
{
	public class OasisDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{
		public OasisDbContext(DbContextOptions<OasisDbContext> options)
			: base(options)
		{
		}

		public DbSet<Category> Categories { get; set; } = null!;
		public DbSet<Contract> Contracts { get; set; } = null!;
		public DbSet<Contractor> Contractors { get; set; } = null!;

		//no db set for application user, identity framework will handle that

		protected override void OnModelCreating(ModelBuilder builder)
		{
			//checks if the assembly is null, if so, it will use the executing assembly
			Assembly configAssembly = Assembly.GetAssembly(typeof(OasisDbContext)) 
				?? Assembly.GetExecutingAssembly();

			builder.ApplyConfigurationsFromAssembly(configAssembly);
			base.OnModelCreating(builder);
		}
	}
}