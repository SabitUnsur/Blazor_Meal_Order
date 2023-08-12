using AutoMapper;
using AutoMapper.QueryableExtensions;
using MealOrdering.Server.Data.Context;
using MealOrdering.Server.Data.Models;
using MealOrdering.Server.Services.Infrastructure;
using MealOrdering.Shared.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Server.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly MealOrderingDbContext context;
        private readonly IConfiguration configuration;

        public UserService(IMapper _mapper, MealOrderingDbContext _Context, IConfiguration _configuration)
        {
            mapper = _mapper;
            context = _Context;
            configuration = _configuration;
        }

        public async Task<UserDTO> CreateUser(UserDTO userDTO)
        {
            var dbUser = await context.Users.Where(x => x.Id == userDTO.Id).FirstOrDefaultAsync();

            if (dbUser != null) throw new Exception("User is already exist");

             dbUser = mapper.Map<Users>(userDTO); //Dbye user tipinde kayıtlamamız gerektigi icin

            await context.Users.AddAsync(dbUser);

            await context.SaveChangesAsync(); 

            return mapper.Map<UserDTO>(dbUser);

        }

        public async Task<bool> DeleteUser(Guid Id)
        {
            var dbUser = await context.Users.Where(x => x.Id == Id).FirstOrDefaultAsync();

            if (dbUser == null) throw new Exception("User not found");

            context.Users.Remove(dbUser);

            int result = await context.SaveChangesAsync(); //degisikliklerden kac satir etkilendi

            return result > 0;
        }

        public async Task<UserDTO> GetUserById(Guid Id)
        {
            return await context.Users.Where(x => x.Id == Id)
            .ProjectTo<UserDTO>(mapper.ConfigurationProvider) //SQL içerisinden sadece UserDTO ile ilgili alanları çekecek
            .FirstOrDefaultAsync();
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            return await context.Users.Where(x => x.IsActive)
              .ProjectTo<UserDTO>(mapper.ConfigurationProvider) //SQL içerisinden sadece UserDTO ile ilgili alanları çekecek
              .ToListAsync();
        }

        public string Login(string email, string password)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));
            var credential = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.Now.AddDays(int.Parse(configuration["JwtExpiryInDays"].ToString()));

            var claims = new[]
            {
                new Claim(ClaimTypes.Email,email)
            };

            var token = new JwtSecurityToken(configuration["JwtIssuer"], configuration["JwtAudience"]
                , claims, null, expireDate, credential);

            string tokenStr = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenStr;

        }

        public async Task<UserDTO> UpdateUser(UserDTO userDTO)
        {
            var dbUser = await context.Users.Where(x => x.Id == userDTO.Id).FirstOrDefaultAsync();

            if (dbUser != null) throw new Exception("User not found");

            mapper.Map(userDTO,dbUser);
            //bu kullanımda aynı olan alanları da tekrar güncellemek yerine sadece değişen yerleri günceller

            context.Users.Update(dbUser);

            return mapper.Map<UserDTO>(dbUser);
        }
    }
}
