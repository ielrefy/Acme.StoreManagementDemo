using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Acme.StoreManagementDemo.CustomValidation
{
    public class GreaterThanZero : ValidationAttribute
    {
        public GreaterThanZero() { }
        public override bool IsValid(object value)
        {
            return   (decimal)value > 0;
        }
    }
}
