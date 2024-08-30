using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.StoreManagementDemo.Categories
{
    public class Category : Entity<int>
    {
        public Category(int id,string name ,  string description):base(id)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
