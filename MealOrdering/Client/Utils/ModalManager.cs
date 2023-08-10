using Blazored.Modal;
using Blazored.Modal.Services;
using MealOrdering.Client.CustomComponents.ModalComponents;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MealOrdering.Client.Utils
{
    public class ModalManager
    {
        private readonly IModalService modalService;

        public ModalManager(IModalService ModalService)
        {
            modalService = ModalService;
        }
        public async Task ShowMessageAsync(string Title,string Message, int duration = 0)
        {
            ModalParameters modalParameters = new();
            modalParameters.Add("Message", Message);

            var modalRef= modalService.Show<ShowMessagePopupComponent>(Title,modalParameters);

            if (duration > 0)
            {
                await Task.Delay(duration);
                modalRef.Close();
            }
        }

        public async Task<bool> ConfirmationAsync(string Title, string Message)
        {
            ModalParameters modalParameters = new();
            modalParameters.Add("Message", Message);

            var modalRef = modalService.Show<ConfirmationPopupComponent>(Title, modalParameters);
            var modalResult = await modalRef.Result;

            return !modalResult.Cancelled;

        }


    }
}
