using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Fitness.Context;
using Fitness.Repositories.AbonamentRepository;
using Fitness.Repositories.AngajatRepository;
using Fitness.Repositories.AntrenorRepository;
using Fitness.Repositories.AntrenorClientRepository;
using Fitness.Repositories.ClasaClientRepository;
using Fitness.Repositories.ClasaRepository;
using Fitness.Repositories.ClientRepository;
using Fitness.Repositories.EchipamentRepository;

namespace Fitness
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<context>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAbonamentRepository, AbonamentRepository>();
            services.AddTransient<IAngajatRepository, AngajatRepository>();
            services.AddTransient<IAntrenorClientRepository, AntrenorClientRepository>();
            services.AddTransient<IAntrenorRepository, AntrenorRepository>();
            services.AddTransient<IClasaClientRepository, ClasaClientRepository>();
            services.AddTransient<IClasaRepository, ClasaRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IEchipamentRepository, EchipamentRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
