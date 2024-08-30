using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.StoreManagementDemo.DTOs.Products
{
    public class CreateUpdateProductDTO : FullAuditedEntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
