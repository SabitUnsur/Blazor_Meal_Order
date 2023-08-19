using Blazored.Modal;
using Blazored.Modal.Services;
using MealOrdering.Client.CustomComponents.ModalComponents;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
=======
using System.Reflection.Metadata;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
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
<<<<<<< HEAD




        public async Task ShowMessageAsync(String Title, String Message, int Duration = 0)
        {
            ModalParameters mParams = new ModalParameters();
            mParams.Add("Message", Message);

            var modalRef = modalService.Show<ShowMessagePopupComponent>(Title, mParams);

            if (Duration > 0)
            {
                await Task.Delay(Duration);
=======
        public async Task ShowMessageAsync(string Title,string Message, int duration = 0)
        {
            ModalParameters modalParameters = new();
            modalParameters.Add("Message", Message);

            var modalRef= modalService.Show<ShowMessagePopupComponent>(Title,modalParameters);
            //ShowMessagePopupComponent içerisinde giden parametreler setlendi

            if (duration > 0)
            {
                await Task.Delay(duration);
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
                modalRef.Close();
            }
        }

<<<<<<< HEAD
        public async Task<bool> ConfirmationAsync(String Title, String Message)
        {
            ModalParameters mParams = new ModalParameters();
            mParams.Add("Message", Message);
            
            var modalRef = modalService.Show<ConfirmationPopupComponent>(Title, mParams);
            //ShowMessagePopupComponent içerisinde giden parametreler setlendi
            var modalResult = await modalRef.Result;

            return !modalResult.Cancelled;
        }

=======
        public async Task<bool> ConfirmationAsync(string Title, string Message)
        {
            ModalParameters modalParameters = new();
            modalParameters.Add("Message", Message);

            var modalRef = modalService.Show<ConfirmationPopupComponent>(Title, modalParameters);
            var modalResult = await modalRef.Result;

            return !modalResult.Cancelled;

        }
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

    }
}
