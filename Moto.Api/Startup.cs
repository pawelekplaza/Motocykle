using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moto.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Moto.Api.Services;
using Moto.Api.Models;

namespace Moto.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=MotocykleDB;Trusted_Connection=True;";
            services.AddDbContext<MotocyklContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IMotocykleRepository, MotocykleRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Motocykl, MotocyklDto>();
                config.CreateMap<MotocyklDto, Motocykl>();
                config.CreateMap<MotocyklForCreationDto, Motocykl>();
            });

            app.UseMvc();
        }
    }
}
