using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Net.Http;

namespace MealOrdering.Client.Utils
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorageService;
        private readonly HttpClient Client;
        private readonly AuthenticationState anonymous;

        public AuthStateProvider(ILocalStorageService localStorageService,HttpClient client)
        {
            this.localStorageService = localStorageService;
            Client = client;
            anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
          
            string apiToken = await localStorageService.GetItemAsStringAsync("token");

            if (string.IsNullOrEmpty(apiToken))
            {
                return anonymous;
            }

            string email = await localStorageService.GetItemAsStringAsync("email");

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Email,email)},"jwtAuthType"));

            Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue
                                                                                    ("Bearer", apiToken);

            //User service icinde token icinde gelen bilgileri belirlemistik, burda ise o tokenla gelen kullanıcının bilgisini aldık.
            // Login olan kullanıcıyı getirme islemleri..

            return new AuthenticationState(claimsPrincipal);
        }

        public void NotifyUserLogin(string email)
        {
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Email, email) }, "jwtAuthType"));

            var authState = Task.FromResult(new AuthenticationState(claimsPrincipal));

            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(anonymous);
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
