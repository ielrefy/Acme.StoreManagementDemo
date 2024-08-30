using Acme.StoreManagementDemo.Categories;
using Acme.StoreManagementDemo.Contracts.Categories;
using Acme.StoreManagementDemo.Contracts.Products;
using Acme.StoreManagementDemo.DTOs.Categories;
using Acme.StoreManagementDemo.DTOs.Products;
using Acme.StoreManagementDemo.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StoreManagementDemo.Services.Products
{

    public class ProductAppService : CrudAppService<Product, ProductDTO, int, PagedAndSortedResultRequestDto, CreateUpdateProductDTO>, IProductsAppService
    {
        public ProductAppService(IRepository<Product, int> repository) : base(repository)
        {

        }
    }

}
