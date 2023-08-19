using MealOrdering.Client.Utils;
using MealOrdering.Shared.CustomExceptions;
using MealOrdering.Shared.DTO;
using MealOrdering.Shared.ResponseModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace MealOrdering.Client.Pages.Users
{   //Razor sayfasında code bölümünü buraya tasidik.
    public class UserListProcess: ComponentBase
    {
=======
namespace MealOrdering.Client.Pages.PageProcess
{
    //Razor sayfasında code bölümünü buraya tasidik.
    public class UserListProcess:ComponentBase
    {
    
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        [Inject]
        public HttpClient Client { get; set; }

        [Inject]
<<<<<<< HEAD
        ModalManager ModalManager { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        protected List<UserDTO> UserList = new List<UserDTO>();


        protected async override Task OnInitializedAsync()
        {
            await LoadList();
        }


        protected void goCreateUserPage()
=======
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
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        {
            NavigationManager.NavigateTo("/users/add");
        }

<<<<<<< HEAD
        protected void goUpdateUserPage(Guid UserId)
        {
            NavigationManager.NavigateTo("/users/edit/" + UserId);
        }

        protected async Task DeleteUser(Guid Id)
        {
            bool confirmed = await ModalManager.ConfirmationAsync("Confirmation", "User will be deleted. Are you sure?");

            if (!confirmed) return;

            try
            {
                bool deleted = await Client.PostGetServiceResponseAsync<bool, Guid>("api/User/Delete", Id, true);

                await LoadList();
            }
            catch (ApiException ex)
            {
                await ModalManager.ShowMessageAsync("User Deletion Error", ex.Message);
            }
            catch (Exception ex)
            {
                await ModalManager.ShowMessageAsync("An Error", ex.Message);
            }
        }

        protected async Task LoadList()
        { //var serviceResponse = await Client.GetFromJsonAsync<ServiceResponse<List<UserDTO>>>("api/User/Users");
            try
            {
                UserList = await Client.GetServiceResponseAsync<List<UserDTO>>("api/User/Users", true);
            }
            catch (ApiException ex)
            {
                await ModalManager.ShowMessageAsync("Api Exception", ex.Message);
            }
            catch (Exception ex)
            {
                await ModalManager.ShowMessageAsync("Exception", ex.Message);
            }
=======
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


>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            //if (serviceResponse.Success) userList = serviceResponse.Value;
        }

    }
}
