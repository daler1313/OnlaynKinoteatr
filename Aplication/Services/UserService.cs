using Aplication.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Services
{
    internal class UserService : IBaseService<User>
    {
        private readonly IBaseRepository<User> _UserRepository;

        public UserService(IBaseRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task<User> CreateAsync(User user, CancellationToken token = default)
        {
            return await _UserRepository.CreateAsync(user, token);
        }

 

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _UserRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _UserRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken token = default)
        {
            return await _UserRepository.GetAllAsync(token);
        }

        public async Task<User> GetAsync(int id, CancellationToken token = default)
        {
            return await _UserRepository.GetAsync(id, token);
        }
        public async Task<bool> UpdateAsync(User Users, CancellationToken token = default)
        {
            var existingUser = await GetAsync(Users.Id);

            if (existingUser is null)
            {
                return false;
            }

            existingUser.Name = Users.Name;
            existingUser.PhoneNumber = Users.PhoneNumber;
            existingUser.Email = Users.Email;




            return await _UserRepository.UpdateAsync(existingUser, token);

        }
    }
}
