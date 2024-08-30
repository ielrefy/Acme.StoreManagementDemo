using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Validation;

namespace Acme.StoreManagementDemo.Shared
{
    public class BaseApplicationService : ApplicationService
    {
        public BaseApplicationService()
        {
             
            
        }

        protected AbpValidationException GetValidationException(FluentValidation.Results.ValidationResult validationResult) {
            string message = string.Join(", ", validationResult.Errors.Select(a => a.ErrorMessage));
            var errors = validationResult.Errors
                         .Select(x => new System.ComponentModel.DataAnnotations.ValidationResult(x.ErrorMessage , [x.PropertyName])).ToList();
            return new AbpValidationException(message, errors);
                }
    }
}
