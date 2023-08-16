using MealOrdering.Client.Utils;
using MealOrdering.Shared.CustomExceptions;
using MealOrdering.Shared.DTO;
using MealOrdering.Shared.ResponseModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MealOrdering.Client.Pages.PageProcess
{
    //Razor sayfasında code bölümünü buraya tasidik.
    public class UserListProcess:ComponentBase
    {
    
        [Inject]
        public HttpClient Client { get; set; }

        [Inject]
        public ModalManager ModalManager { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }


        protected List<UserDTO> userList = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadList();

            base.OnInitialized();
        }

        protected void GoCreateUserPage()
        {
            NavigationManager.NavigateTo("/users/add");
        }

        protected void GoEditUserPage(Guid userId)
        {
            NavigationManager.NavigateTo("/users/edit/" + userId);
        }


        protected async Task LoadList()
        {
           //var serviceResponse = await Client.GetFromJsonAsync<ServiceResponse<List<UserDTO>>>("api/User/Users");

            try
            {
                userList  = await Client.GetServiceResponseAsync<List<UserDTO>>("api/User/Users", true);
            }
            catch (ApiException ex) { await ModalManager.ShowMessageAsync("API Exception", ex.Message); }

            catch (Exception ex) { await ModalManager.ShowMessageAsync(" Exception", ex.Message); }


            //if (serviceResponse.Success) userList = serviceResponse.Value;
        }

    }
}
