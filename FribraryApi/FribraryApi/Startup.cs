using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;
using FribraryAPI.EntityFramework;
using FribraryApi.Services;
using AutoMapper;

namespace FribraryApi
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
            services.AddMvc();
            services.AddAutoMapper();
            services.AddSwaggerGen(options => options.SwaggerDoc("v1", new Info { Title = "Fribrary API", Version = "v1" }));
            services.AddDbContext<FribraryApiContext>(options => options.UseSqlite("Data Source = FribrarySongs.db"));
            services.AddFribaryApiServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "Fribrary API v1"));
            }

            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<FribraryApiContext>();
                context.Database.Migrate();
            }

        }
    }
}
