using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.HomeWork.CatOperations.CreateCat;

namespace UnluCo.Week1.HomeWork.CatOperations.PostCat
{
    public class AddCatCommandValidator : AbstractValidator<AddCatCommand>
    {
        public AddCatCommandValidator()  //Değişkenleri alabileceği kuralların belirlendiği komut
        {
            RuleFor(command => command.Model.GenderId).GreaterThan(0);
            RuleFor(command => command.Model.Age).GreaterThan(0);
            RuleFor(command => command.Model.DateOfBirth.Date).NotEmpty();
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(2).MaximumLength(18);
        }


    }
}
