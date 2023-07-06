using Marauder_s_Oasis.Data;
using Marauders_Oasis.Data.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Marauder_s_Oasis
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			string connectionString =
				builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services.AddDbContext<OasisDbContext>(options =>
				options.UseSqlServer(connectionString));
			builder.Services.AddDatabaseDeveloperPageExceptionFilter(); //Not essential, this line of code is for when you have not migrated the database yet.

			builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");

				options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
				options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");

				options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
				options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");

			})
				.AddEntityFrameworkStores<OasisDbContext>();
			builder.Services.AddControllersWithViews();

			WebApplication app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
				app.UseDeveloperExceptionPage(); //Useful while in development.
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication(); //1
			app.UseAuthorization();  //2

			app.MapDefaultControllerRoute();  //If I want to add custom routes, I can do so here, later.
			app.MapRazorPages();

			app.Run();
		}
	}
}