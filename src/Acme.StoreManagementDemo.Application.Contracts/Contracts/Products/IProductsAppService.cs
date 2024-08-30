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
    //public interface IProductsAppService : ICrudAppService<ProductDTO, int, PagedAndSortedResultRequestDto, CreateUpdateProductDTO>
    //{

    //}
    public interface IProductsAppService
    {
        public Task<ProductDTO> GetProductByIdAsync(int id);
        public Task<ProductDTO> CreateProductAsync(CreateUpdateProductDTO product);
        public Task<ProductDTO> UpdateProductAsync(CreateUpdateProductDTO product);
        public Task<bool> DeleteProductByIdAsync(int Id);
        public Task<PagedResultDto<ProductDTO>> GetProductsAsync(ProductListDTO request);

    }

}
