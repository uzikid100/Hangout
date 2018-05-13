using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Database;
using Hangout.Repository;
using Hangout.Repository.Interfaces;
using Hangout.RequestHandlers;
using Hangout.RequestHandlers.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hangout
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();

            ConfigureDatabase(services);
            ConfigureDependencyInjection(services);
        }

        private void ConfigureDependencyInjection(IServiceCollection services)
        {
            // Handlers Config
            services.AddTransient<IUserRequestHandler, UserRequestHandler>();
            services.AddTransient<IFriendRequestHandler, FriendRequestHandler>();
            
            // Repo Config
            services.AddScoped<IUserRepository, UserEFRepository>();
            services.AddScoped<IFriendRepository, FriendEFRepository>();
        }

        private void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<HangoutContext>(context =>
            {
                var connectionString = Configuration.GetConnectionString("DefaultConnection");
                context.UseSqlServer(connectionString);
            }, ServiceLifetime.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseMvc();
        }
    }
}
