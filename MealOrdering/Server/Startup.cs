<<<<<<< HEAD
using Blazored.LocalStorage;
using Blazored.Modal;
using MealOrdering.Server.Data.Context;
using MealOrdering.Server.Middlewares;
using MealOrdering.Server.Services.Extensions;
using MealOrdering.Server.Services.Infrastruce;
using MealOrdering.Server.Services.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;
=======
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Blazored.Modal;
using MealOrdering.Server.Services.Extensions;
using MealOrdering.Server.Services.Infrastructure;
using MealOrdering.Server.Services.Services;
using MealOrdering.Server.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Blazored.LocalStorage;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddBlazoredModal();

            services.ConfigureMapping();

            services.AddHttpContextAccessor();
            services.AddScoped<HttpContextAccessor>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IValidationService, ValidationService>();

            

            services.AddDbContext<MealOrderingDbContext>(config => 
=======
            services.AddControllersWithViews();
            services.AddBlazoredModal();
            services.AddRazorPages();
            services.ConfigureMapping();
            services.AddScoped<IUserService, UserService>();
            services.AddDbContext<MealOrderingDbContext>(config =>
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            {
                config.UseNpgsql("User ID=postgres;password=123;Host=localhost;Port=5432;Database=MealOrdering;SearchPath=public");
                config.EnableSensitiveDataLogging();
            });

<<<<<<< HEAD
            services.AddAuthentication(opt => 
=======
            services.AddAuthentication(opt =>
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
<<<<<<< HEAD
            .AddJwtBearer(options => 
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                { 
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["JwtIssuer"],
                    ValidAudience = Configuration["JwtAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]))
                };
            });

=======
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["JwtIssuer"],
                        ValidAudience = Configuration["JwtAudience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]))
                    };
                });
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            services.AddBlazoredLocalStorage();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

<<<<<<< HEAD
            app.UseMiddleware<ExceptionHandlingMiddleware>();

=======
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

<<<<<<< HEAD
            app.UseAuthentication();
            app.UseAuthorization();
=======
            app.UseAuthorization();
            app.UseAuthentication();
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
