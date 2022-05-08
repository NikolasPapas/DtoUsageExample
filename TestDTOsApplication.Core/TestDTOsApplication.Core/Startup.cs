using TestDTOsApplication.Common.Interfaces;
using TestDTOsApplication.Common.Servises;
using TestDTOsApplication.Common.Controllers;
using TestDTOsApplication.ExternalServices.DataServices;
using TestDTOsApplication.ExternalServices.DataInterfaces;

namespace TestDTOsApplication.Core
{
	public class Startup
	{

        public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			RegisterCommonServices(services);
			RegisterExternalServices(services);

			services.AddSwagger(this.Configuration.GetSection("OpenAPI"));
			services.AddControllers()
				.AddApplicationPart(typeof(TesDtoContoller).Assembly);
		}

        private void RegisterCommonServices(IServiceCollection services)
		{
			// Add you Common service and Configuration initialization
            services.AddTransient<IMainService, MainService>();
		}

		private void RegisterExternalServices(IServiceCollection services)
		{
            // Add you External service and Configuration initialization
            services.AddSingleton<IDataRepository, DataRepository>();
            services.AddSingleton<IDataServiseId, DataServiseId>();
            services.AddSingleton<IDataServiseInformation, DataServiseInformation>();
        }

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.ConfigureSwagger();
			app.UseDefaultFiles();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}