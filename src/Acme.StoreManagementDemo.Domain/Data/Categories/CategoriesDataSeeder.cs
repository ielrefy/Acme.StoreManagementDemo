using Acme.StoreManagementDemo.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.StoreManagementDemo.Data.Categories
{
    public class CategoriesDataSeeder : IDataSeedContributor,ITransientDependency
    {
        private readonly IRepository<Category,int> _categoriesrepository;
        public CategoriesDataSeeder(IRepository<Category,int> categoriesrepository)
        {
                _categoriesrepository = categoriesrepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
         var categories = new List<Category>() { 
         new Category(1 , "Foods&Drinks" ,"Category for foods & Drinks products" )
          ,
         new Category(2 , "Electronics" ,"Category for Electronics products" )
         
         };

          if(!await _categoriesrepository.AnyAsync()) 
            await _categoriesrepository.InsertManyAsync(categories);
            
        }
        
    }
}
