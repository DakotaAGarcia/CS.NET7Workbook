using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Packt.Shared;

public static class NorthwindContextExtensions
{
	public static IServiceCollection AddNortwindContext(
		this IServiceCollection services, string relativePath = "..")
	{
		string databasePath = Path.Combine(relativePath, "Northwind.db");
		services.AddDbContext<NorthwindContext>(options  =>
		{
			options.UseSqlite($"Data Source={databasePath}");

			options.LogTo(WriteLine,
				new[] { Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting });
		});

		return services;
	}
}