using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using UnluCo.Week1.HomeWork.DBOperations;
using UnluCo.Week1.HomeWork.Middlewares;
using UnluCo.Week1.HomeWork.Services;

namespace UnluCo.Week1.HomeWork
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

            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "UnluCo.Week1.HomeWork", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
            });

            services.AddDbContext<CatStoreDbContext>(options => options.UseInMemoryDatabase(databaseName: "CatStoreDb"));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<ILoggerService,ConsoleLogger>();
            /*Singleton: Uygulamanýn çalýþmaya baþladýðý andan duruncaya kadar geçen süre
             *boyunca bir kez oluþturulur ve her zaman ayný nesne kullanýlýr.*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "UnluCo.Week1.HomeWork v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCustomExceptionMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
