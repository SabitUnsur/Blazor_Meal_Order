using AutoMapper;
using AutoMapper.QueryableExtensions;
using MealOrdering.Server.Data.Context;
using MealOrdering.Server.Data.Models;
<<<<<<< HEAD
using MealOrdering.Server.Services.Infrastruce;
=======
using MealOrdering.Server.Services.Infrastructure;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
using MealOrdering.Shared.DTO;
using MealOrdering.Shared.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
<<<<<<< HEAD
=======
using System.Security.Cryptography;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Server.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly MealOrderingDbContext context;
        private readonly IConfiguration configuration;

<<<<<<< HEAD
        public UserService(IMapper Mapper, MealOrderingDbContext Context, IConfiguration Configuration)
        {
            mapper = Mapper;
            context = Context;
            configuration = Configuration;
        }


        public async Task<UserDTO> CreateUser(UserDTO User)
        {
            var dbUser = await context.Users.Where(i => i.Id == User.Id).FirstOrDefaultAsync();

            if (dbUser != null)
                throw new Exception("User already exists");


            dbUser = mapper.Map<Data.Models.Users>(User);//Dbye user tipinde kayıtlamamız gerektigi icin

            dbUser.Password= PasswordEncrypter.Encrypt(User.Password);

            await context.Users.AddAsync(dbUser);
            int result = await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(dbUser);
        }

        public async Task<bool> DeleteUserById(Guid Id)
        {
            var dbUser = await context.Users.FirstOrDefaultAsync(i => i.Id == Id);

            if (dbUser == null)
                throw new Exception("User not found");

            context.Users.Remove(dbUser);
            int result = await context.SaveChangesAsync();
=======
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
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            return result > 0;
        }

        public async Task<UserDTO> GetUserById(Guid Id)
        {
<<<<<<< HEAD
            return await context.Users
                        .Where(i => i.Id == Id)
                        .ProjectTo<UserDTO>(mapper.ConfigurationProvider)
                        .FirstOrDefaultAsync();
=======
            return await context.Users.Where(x => x.Id == Id)
            .ProjectTo<UserDTO>(mapper.ConfigurationProvider) //SQL içerisinden sadece UserDTO ile ilgili alanları çekecek
            .FirstOrDefaultAsync();
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        }

        public async Task<List<UserDTO>> GetUsers()
        {
<<<<<<< HEAD
            return await context.Users
                        .Where(i => i.IsActive)
                        .ProjectTo<UserDTO>(mapper.ConfigurationProvider)
                        .ToListAsync();
        }

        public async Task<UserLoginResponseDTO> Login(string EMail, string Password)
        {
            // Veritabanı Kullanıcı Doğrulama İşlemleri Yapıldı.

            var encryptedPassword = PasswordEncrypter.Encrypt(Password);

            var dbUser = await context.Users.FirstOrDefaultAsync(i => i.EMailAddress == EMail && i.Password == encryptedPassword);
=======
            return await context.Users.Where(x => x.IsActive)
              .ProjectTo<UserDTO>(mapper.ConfigurationProvider) //SQL içerisinden sadece UserDTO ile ilgili alanları çekecek
              .ToListAsync();
        }

        public async Task<UserLoginResponseDTO> Login(string email, string password)
        {
            var encryptedPassword = PasswordEncryptor.Encrypt(password);

            var dbUser = await context.Users.FirstOrDefaultAsync(i => i.EMailAddress == email && i.Password == encryptedPassword);
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

            if (dbUser == null)
                throw new Exception("User not found or given information is wrong");

            if (!dbUser.IsActive)
                throw new Exception("User state is Passive!");

<<<<<<< HEAD

            UserLoginResponseDTO result = new UserLoginResponseDTO();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(int.Parse(configuration["JwtExpiryInDays"].ToString()));

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, EMail),
                new Claim(ClaimTypes.Name, dbUser.FirstName + " " + dbUser.LastName),
                new Claim(ClaimTypes.UserData, dbUser.Id.ToString())
            };

            var token = new JwtSecurityToken(configuration["JwtIssuer"], configuration["JwtAudience"], claims, null, expiry, creds);

            result.ApiToken = new JwtSecurityTokenHandler().WriteToken(token);
            result.User = mapper.Map<UserDTO>(dbUser);

            return result;
        }

        public async Task<UserDTO> UpdateUser(UserDTO User)
        {
            var dbUser = await context.Users.Where(i => i.Id == User.Id).FirstOrDefaultAsync();

            if (dbUser == null)
                throw new Exception("User not found");


            mapper.Map(User, dbUser);

            int result = await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(dbUser);
        }

        
=======
            UserLoginResponseDTO userLoginResponse = new();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));
            var credential = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.Now.AddDays(int.Parse(configuration["JwtExpiryInDays"].ToString()));

            var claims = new[]
            {
                new Claim(ClaimTypes.Email,email)
            };

            var token = new JwtSecurityToken(configuration["JwtIssuer"], configuration["JwtAudience"]
                , claims, null, expireDate, credential);

            userLoginResponse.ApiToken = new JwtSecurityTokenHandler().WriteToken(token);
            userLoginResponse.User = mapper.Map<UserDTO>(dbUser);

            return userLoginResponse;

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
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    }
}
