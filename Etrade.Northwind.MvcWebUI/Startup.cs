using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etrade.Northwind.Business.Abstract;
using Etrade.Northwind.Business.Concrete;
using Etrade.Northwind.DataAccess.Abstract;
using Etrade.Northwind.DataAccess.Concrete.EntityFramework;
using Etrade.Northwind.MvcWebUI.Entities;
using Etrade.Northwind.MvcWebUI.Middlewares;
using Etrade.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Etrade.Northwind.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Northwind; Trusted_Connection = True; MultipleActiveResultSets = true"));
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>(options=>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddRoleManager<RoleManager<CustomIdentityRole>>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();

            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);
            app.UseIdentity();
            app.UseSession();
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            //uygulama açıldığında hangi sayfa ile açılacağı seçilir
            routeBuilder.MapRoute("Default","{controller=Product}/{action=Index}/{id?}");
        }

    }
}
