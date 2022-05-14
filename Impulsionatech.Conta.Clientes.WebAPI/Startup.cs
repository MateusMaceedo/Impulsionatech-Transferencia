using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Impulsionatech.Conta.Clientes
{
    public class Startup
    {
        public IHostEnvironment Environment { get; set; }   
        public Startup(IConfiguration configuration, IHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;  
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettions.json")
                .AddEnvironmentVariables()
                .Build();

            services.AddControllers();
            //services.ConfigurarJson();
            //services.ConfigurarSplunk(configuration);
            //services.ConfigurarSwagger();
            //services.ConfigurarSecretManager(Configuration);
            //services.ConfigurarAutoMapper();
            //services.RegisterDependecyInversion(configuration, Environment);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            //app.UseSwagger();
            //app.UseSwaggerIU(swagger =>
            //{
            //    swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "TimeA");
            //});

            //app.UseMiddleware(typeof(ExceptionMiddleware));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
