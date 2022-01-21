using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.CatOperations.GetByIdCats
{
    public class GetByIdCatsQueryValidator : AbstractValidator<GetByIdCatsQuery>
    {
        public GetByIdCatsQueryValidator() //Değişkenleri alabileceği kuralların belirlendiği komut
        {
            RuleFor(query => query.CatId).GreaterThan(0);
            
        }
    }
}
