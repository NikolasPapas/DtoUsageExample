using Microsoft.OpenApi.Models;
using TestDTOsApplication.Common.Types.Swagger;

namespace TestDTOsApplication.Core
{
	public static class Extensions
	{
		public static IServiceCollection AddSwagger(this IServiceCollection services, IConfigurationSection configurationSection)
		{
			services.Configure<OpenAPIConfiguration>(configurationSection);

			services.AddSwaggerGen(c =>
			{
				DirectoryInfo dir = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
				foreach (var fi in dir.EnumerateFiles("*.xml"))
					c.IncludeXmlComments(fi.FullName);

				c.CustomSchemaIds(type => type.ToString());

				//OpenAPIConfiguration openAPIConfiguration = new OpenAPIConfiguration();
				//configurationSection.Bind(openAPIConfiguration);
				//string desc = "";
				//try
				//{
				//	desc = System.IO.File.ReadAllText($"{dir}//Desc.html");
				//}
				//catch (Exception ex)
				//{
				//	var e = ex;
				//}
				///c.SwaggerDoc(openAPIConfiguration.DocumentVersion, new OpenApiInfo { Title = openAPIConfiguration.DocumentTitle, Version = openAPIConfiguration.DocumentVersion, Description = desc });
			});
			services.AddSwaggerGenNewtonsoftSupport();
			return services;
		}

		public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{

			});
			return app;
		}
	}
}
