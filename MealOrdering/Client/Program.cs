using Blazored.LocalStorage;
using Blazored.Modal;
using MealOrdering.Client.Utils;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
<<<<<<< HEAD
            builder.RootComponents.Add<App>("app");
=======
            builder.RootComponents.Add<App>("#app");
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            builder.Services.AddScoped<ModalManager>();

            builder.Services.AddBlazoredModal();

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddAuthorizationCore();
<<<<<<< HEAD
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();

=======

            builder.Services.AddScoped<AuthenticationStateProvider,AuthStateProvider>();
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            await builder.Build().RunAsync();
        }
    }
}
