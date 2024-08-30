using Acme.StoreManagementDemo.DTOs.Categories;
using Acme.StoreManagementDemo.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.StoreManagementDemo.Contracts.Products
{
    public interface IProductsAppService : ICrudAppService<ProductDTO, int, PagedAndSortedResultRequestDto, CreateUpdateProductDTO>
    {

    }
    
}
