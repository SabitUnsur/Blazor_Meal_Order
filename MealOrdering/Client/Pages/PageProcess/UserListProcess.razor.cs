using MealOrdering.Shared.DTO;
using MealOrdering.Shared.ResponseModels;
using Microsoft.AspNetCore.Components;
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

        protected List<UserDTO> userList = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadList();

            base.OnInitialized();
        }

        protected async Task LoadList()
        {
           var serviceResponse = await Client.GetFromJsonAsync<ServiceResponse<List<UserDTO>>>("api/User/Users");

            if (serviceResponse.Success) userList = serviceResponse.Value;
        }

    }
}
