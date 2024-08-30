using Acme.StoreManagementDemo.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.StoreManagementDemo.DTOs.Products
{
    public class CreateUpdateProductDTO : AuditedEntityDto<int>
    {

        [Required(AllowEmptyStrings =false , ErrorMessage ="Name can not be empty !")]
        public string Name { get; set; }
        public string Description { get; set; }
        // commented to be used with fluent validator rather than custom validation attribute
       // [GreaterThanZero(ErrorMessage = "price should be greater than 0 !")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
