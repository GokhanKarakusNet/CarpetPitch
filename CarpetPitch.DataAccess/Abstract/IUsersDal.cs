using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.DataAccess;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.DataAccess.Abstract
{
    public interface IUsersDal : IEntityRepository<User>
    {
    }
}
