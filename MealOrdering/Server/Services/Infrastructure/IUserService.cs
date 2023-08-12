using MealOrdering.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MealOrdering.Server.Services.Infrastructure
{
    public interface IUserService
    {
        public Task<UserDTO> GetUserById(Guid Id);
        public Task<List<UserDTO>> GetUsers();
        public Task<UserDTO> CreateUser(UserDTO userDTO);
        public Task<UserDTO> UpdateUser(UserDTO userDTO);
        public Task<bool> DeleteUser(Guid Id);

    }
}
