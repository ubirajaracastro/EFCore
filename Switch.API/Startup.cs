using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Switch.Infra.Data.Context;

namespace Switch.API
{
    public class Startup    
    {
        IConfiguration config { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("config.json");
            config = builder.Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {
            var conexao = config.GetConnectionString("SwitchDB");
            services.AddDbContext<SwitchContext>(option => option.UseLazyLoadingProxies()
                                                           .UseMySql(conexao, m => m.MigrationsAssembly("Switch.Infra.Data")));

            services.AddMvcCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
