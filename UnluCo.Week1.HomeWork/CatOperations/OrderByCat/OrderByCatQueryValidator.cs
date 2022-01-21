using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.CatOperations.OrderByCat
{
    public class OrderByCatQueryValidator : AbstractValidator<OrderByCatQuery>

    {

        public OrderByCatQueryValidator() //Değişkenleri alabileceği kuralların belirlendiği komut
        {
            RuleFor(query => query.colon).Equal("Name").NotNull();
        }
    }
}
