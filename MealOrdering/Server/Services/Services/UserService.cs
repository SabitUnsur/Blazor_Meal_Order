using AutoMapper;
using AutoMapper.QueryableExtensions;
using MealOrdering.Server.Data.Context;
using MealOrdering.Server.Data.Models;
using MealOrdering.Server.Services.Infrastructure;
using MealOrdering.Shared.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrdering.Server.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly MealOrderingDbContext context;

        public UserService(IMapper _mapper,MealOrderingDbContext _Context)
        {
            mapper = _mapper;
            context = _Context;
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
