using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.CatOperations.UpdateCat
{
    public class UpdateCatCommandValidator :AbstractValidator<UpdateCatCommand>
    {
        public UpdateCatCommandValidator() //Değişkenleri alabileceği kuralların belirlendiği komut
        {
            RuleFor(command => command.CatId).GreaterThan(0);
            RuleFor(command => command.Model.Age).GreaterThan(0);
            RuleFor(command => command.Model.GenderId).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(2).MaximumLength(18);
            RuleFor(command => command.Model.Color).NotEmpty();
            
        }


    }
}
