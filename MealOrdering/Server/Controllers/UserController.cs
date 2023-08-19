<<<<<<< HEAD
﻿using MealOrdering.Server.Services.Infrastruce;
=======
﻿using MealOrdering.Server.Services.Infrastructure;
using MealOrdering.Server.Services.Services;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
using MealOrdering.Shared.DTO;
using MealOrdering.Shared.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
using System.Threading.Tasks;

namespace MealOrdering.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
<<<<<<< HEAD
        private readonly IUserService userService;

        public UserController(IUserService UserService)
        {
            userService = UserService;
=======
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        }

        [HttpPost("Login")]
        [AllowAnonymous]
<<<<<<< HEAD
        public async Task<ServiceResponse<UserLoginResponseDTO>> Login(UserLoginRequestDTO UserRequest)
        {
            return new ServiceResponse<UserLoginResponseDTO>()
            {
                Value = await userService.Login(UserRequest.Email, UserRequest.Password)
            };
        }

        [HttpGet("Users")]
=======
        public async Task<ServiceResponse<UserLoginResponseDTO>> Login(UserLoginRequestDTO userLoginRequestDTO)
        {
            return new ServiceResponse<UserLoginResponseDTO>()
            {
                Value = await  _userService.Login(userLoginRequestDTO.Email, userLoginRequestDTO.Password)
            };
        }


        [HttpGet("Users")]
        [AllowAnonymous]
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        public async Task<ServiceResponse<List<UserDTO>>> GetUsers()
        {
            return new ServiceResponse<List<UserDTO>>()
            {
<<<<<<< HEAD
                Value = await userService.GetUsers()
=======
                Value = await _userService.GetUsers()
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            };
        }

        [HttpPost("Create")]
        public async Task<ServiceResponse<UserDTO>> CreateUser([FromBody] UserDTO User)
        {
            return new ServiceResponse<UserDTO>()
            {
<<<<<<< HEAD
                Value = await userService.CreateUser(User)
=======
                Value = await _userService.CreateUser(User)
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            };
        }

        [HttpPost("Update")]
        public async Task<ServiceResponse<UserDTO>> UpdateUser([FromBody] UserDTO User)
        {
            return new ServiceResponse<UserDTO>()
            {
<<<<<<< HEAD
                Value = await userService.UpdateUser(User)
=======
                Value = await _userService.UpdateUser(User)
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            };
        }

        [HttpGet("UserById/{Id}")]
<<<<<<< HEAD
=======
        [AllowAnonymous]
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        public async Task<ServiceResponse<UserDTO>> GetUserById(Guid Id)
        {
            return new ServiceResponse<UserDTO>()
            {
<<<<<<< HEAD
                Value = await userService.GetUserById(Id)
=======
                Value = await _userService.GetUserById(Id)
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            };
        }


        [HttpPost("Delete")]
<<<<<<< HEAD
        public async Task<ServiceResponse<bool>> DeleteUser([FromBody]Guid id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await userService.DeleteUserById(id)
            };
        }
=======
        public async Task<ServiceResponse<bool>> DeleteUser([FromBody] Guid id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await _userService.DeleteUser(id)
            };
        }

>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    }
}
