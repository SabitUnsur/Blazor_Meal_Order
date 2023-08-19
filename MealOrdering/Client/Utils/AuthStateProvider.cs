using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
=======
using System.Threading.Tasks;
using System.Security.Claims;
using System.Net.Http;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Client.Utils
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorageService;
<<<<<<< HEAD
        private readonly HttpClient client;
        private readonly AuthenticationState anonymous;

        public AuthStateProvider(ILocalStorageService LocalStorageService, HttpClient Client)
        {
            localStorageService = LocalStorageService;
            client = Client;
            anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            String apiToken = await localStorageService.GetItemAsStringAsync("token");

            if (String.IsNullOrEmpty(apiToken))
                return anonymous;


            String email = await localStorageService.GetItemAsStringAsync("email");

            var cp = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Email, email) }, "jwtAuthType"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
=======
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
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            //User service icinde token icinde gelen bilgileri belirlemistik, burda ise o tokenla gelen kullanıcının bilgisini aldık.
            // Login olan kullanıcıyı getirme islemleri..

<<<<<<< HEAD
            return new AuthenticationState(cp);
        }

        public void NotifyUserLogin(String email)
        {
            var cp = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Email, email) }, "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(cp));
=======
            return new AuthenticationState(claimsPrincipal);
        }

        public void NotifyUserLogin(string email)
        {
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Email, email) }, "jwtAuthType"));

            var authState = Task.FromResult(new AuthenticationState(claimsPrincipal));
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(anonymous);
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
