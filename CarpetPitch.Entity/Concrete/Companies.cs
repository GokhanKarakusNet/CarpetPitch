using CarpetPitch.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetPitch.Entity.Concrete
{
    public class Company:IEntity
    {
        public int CompanyId  { get; set; }
        public string Cname { get; set; }
        public string TaxNumber { get; set; }
        public string Email { get; set; }
        public City Cities { get; set; }
        public int? CityId { get; set; }
        public string CompanyAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime TsCreated { get; set; }
        public DateTime TsUpdated { get; set; }
        public string Details { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

    }
}
