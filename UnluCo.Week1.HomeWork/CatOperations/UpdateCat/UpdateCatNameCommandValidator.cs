using FluentValidation;

namespace UnluCo.Week1.HomeWork.CatOperations.UpdateCat
{
    public class UpdateCatNameCommandValidator : AbstractValidator<UpdateCatNameCommand>
    {
        public UpdateCatNameCommandValidator() //Değişkenleri alabileceği kuralların belirlendiği komut
        {
            RuleFor(command => command.CatId).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(2).MaximumLength(18);


        }


    }
}
