using MealOrdering.Shared.DTO;
using System;
using System.Threading.Tasks;

namespace MealOrdering.Server.Services.Infrastructure
{
    public interface IUserService
    {
        public Task<UserDTO> GetUserById(Guid Id);
        public Task<UserDTO> GetUsers();
        public Task<UserDTO> CreateUser(UserDTO userDTO);
        public Task<UserDTO> UpdateUser(UserDTO userDTO);
        public Task<UserDTO> DeleteUser(Guid Id);




    }
}
