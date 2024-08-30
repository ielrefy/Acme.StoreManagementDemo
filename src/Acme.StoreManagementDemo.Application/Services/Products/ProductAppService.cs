using Acme.StoreManagementDemo.Categories;
using Acme.StoreManagementDemo.Contracts.Categories;
using Acme.StoreManagementDemo.Contracts.Products;
using Acme.StoreManagementDemo.DTOs.Categories;
using Acme.StoreManagementDemo.DTOs.Products;
using Acme.StoreManagementDemo.Products;
using Acme.StoreManagementDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.ObjectMapping;
using FluentValidation;
using System.Net;

namespace Acme.StoreManagementDemo.Services.Products
{

    public class ProductAppService : BaseApplicationService, IProductsAppService
    {
        #region Attributes
        private readonly IRepository<Product,int> _productRepository;
        #endregion

        #region ctor
        public ProductAppService(IRepository<Product,int> productRepository) 
        {
         _productRepository = productRepository;
        }
        #endregion

        #region Actions
        public async Task<ProductDTO> CreateProductAsync(CreateUpdateProductDTO input)
        {
            Guid userid = new Guid();  // get login user id
            input.CreationTime = DateTime.Now;
            input.CreatorId = userid;

            var validationresult =await new CreateUpdateProductDTOValidator().ValidateAsync(input);
            if (!validationresult.IsValid) 
            {
                var exception = GetValidationException(validationresult);
                throw exception;
            }
            var product = ObjectMapper.Map<CreateUpdateProductDTO, Product>(input);
            

            var inserted = await _productRepository.InsertAsync(product);
            return ObjectMapper.Map<Product, ProductDTO >(inserted);
        }
        public async Task<bool> DeleteProductByIdAsync(int id)
        {
            
            var exist = await _productRepository.AnyAsync(x => x.Id == id);
            if (exist) 
            {
                await _productRepository.DeleteDirectAsync(x => x.Id == id );
                return true;
            }
            return false;
        }
        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var product =await _productRepository.WithDetailsAsync(p => p.Category ).Result.Where(a => a.Id == id)
                                   .FirstOrDefaultAsync();

            return ObjectMapper.Map<Product, ProductDTO>(product);
        }
        public async Task<PagedResultDto<ProductDTO>> GetProductsAsync(ProductListDTO input)
        {
            if (input.Sorting.IsNullOrEmpty())
                input.Sorting = nameof(Product.Id);

            var products = await _productRepository.WithDetailsAsync(p => p.Category)
                                                   .Result
                                                   .AsQueryable()
                                                   .WhereIf(!input.Filter.IsNullOrEmpty(), p => p.Name.Contains(input.Filter))
                                                   .Skip(input.SkipCount).Take(input.MaxResultCount)
                                                   .OrderBy(input.Sorting).ToListAsync();

            var totalCount = !input.Filter.IsNullOrEmpty() ?
                              await _productRepository.CountAsync(p => p.Name.Contains(input.Filter)) 
                              :await _productRepository.CountAsync();

            var output = new PagedResultDto<ProductDTO>()
            {
                TotalCount = totalCount,
                Items = ObjectMapper.Map<List<Product>, List<ProductDTO>>(products)
            };
            return output;
        }
        public  async Task<ProductDTO> UpdateProductAsync(CreateUpdateProductDTO input)
        {
            Guid userid = new Guid();  // get login user id
            input.LastModificationTime = DateTime.Now;
            input.LastModifierId = userid;

            var product = ObjectMapper.Map<CreateUpdateProductDTO, Product>(input);
            var updated = await _productRepository.UpdateAsync(product);
            return ObjectMapper.Map<Product, ProductDTO>(updated);
        }
        #endregion
    }

}
