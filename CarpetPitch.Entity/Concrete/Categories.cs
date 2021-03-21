using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.Entities;

namespace CarpetPitch.Entity.Concrete
{
   public class Categories:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
