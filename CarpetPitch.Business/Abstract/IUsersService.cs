using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.Business.Abstract
{
   public interface IUsersService
   {
       User Add(User users);
       Task<User> AddAsync(User users);
       User Update(User users);
       Task<User> UpdateAsync(User users);
       void Delete(User users);
       User GetById(int id);
       List<User> GetList();

   }
}
