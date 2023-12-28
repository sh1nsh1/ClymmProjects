using shop.Data.Interfaces;
using shop.Data.Models;
using shop.Data.Repository;
using Microsoft.EntityFrameworkCore;
using shop.Data;

namespace shop{
    public class Startup{

        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder()
                .SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public  void ConfigureServices(IServiceCollection services){
            services.AddDbContext<AppDbContext>(options => options
            .UseNpgsql(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc(option=> option.EnableEndpointRouting = false);
            services.AddTransient<IAllCharacters, CharacterRepository>();
            services.AddTransient<IAllTeams, TeamRepository>();
            services.AddTransient<IAllOrders, OrderRepository>();
        }
        public void Configure(IApplicationBuilder app, IHostEnvironment env){
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                
                app.UseStaticFiles();
                app.UseMvcWithDefaultRoute();
                app.UseMvc(routes =>
                {
                    routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                    
                });
                using (var scope = app.ApplicationServices.CreateScope()){
                    DBObject.Initial(scope.ServiceProvider.GetRequiredService<AppDbContext>());
                }
            }

        }
    }
}