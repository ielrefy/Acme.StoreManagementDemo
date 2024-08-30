using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.StoreManagementDemo.DTOs.Products
{
    public class ProductListDTO : PagedAndSortedResultRequestDto
    {
        public string  Filter { get; set; } 
    }
}
