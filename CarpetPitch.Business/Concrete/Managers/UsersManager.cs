using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Business.Abstract;
using CarpetPitch.DataAccess.Abstract;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.Business.Concrete.Managers
{
    public class UsersManager:IUsersService
    {
        private readonly IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }
        public User Add(User users)
        {
            return _usersDal.Add(users);
        }

        public async Task<User> AddAsync(User users)
        {
            return await _usersDal.AddAsync(users);
        }

        public User Update(User users)
        {
            return _usersDal.Update(users);
        }

        public async Task<User> UpdateAsync(User users)
        {
            return await _usersDal.UpdateAsync(users);
        }

        public void Delete(User users)
        {
            _usersDal.Delete(users);
        }

        public User GetById(int id)
        {
            return _usersDal.Get(d => d.UserId == id);
        }

        public List<User> GetList()
        {
            return _usersDal.GetAll();
        }
    }
}
