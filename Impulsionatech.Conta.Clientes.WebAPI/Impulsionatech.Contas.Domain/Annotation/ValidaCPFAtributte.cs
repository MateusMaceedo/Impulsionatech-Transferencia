using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Impulsionatech.Contas.Domain.Annotation
{
    public class ValidaCPFAtributte : ValidationAttribute
    {
        public ValidaCPFAtributte() : base("CPF Informa não é valido")
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool valido = Util.ValidaCPF(value.ToString());
            if (valido)
                return null;
            return new ValidationResult(base.FormatErrorMessage(validationContext.MemberName))
                , new string[] { validationContext.MemberName });    
        }
    }
}
