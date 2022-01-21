using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.CatOperations.DeleteCat
{
    public class DeleteCatCommandValidator : AbstractValidator<DeleteCatCommand>
    {


        public DeleteCatCommandValidator() //Değişkenleri alabileceği kuralların belirlendiği komut
        {
            RuleFor(command => command.CatId).GreaterThan(0);
        }

    }
}
