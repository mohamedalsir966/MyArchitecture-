using FluentValidation;
using Service.LookupFeaturs.Commands;


namespace Service.Validators
{
  
    public class CreateVaccinCommandValidator : AbstractValidator<CreateVaccinCommand>
    {
        public CreateVaccinCommandValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.TotalNumOfDose).GreaterThanOrEqualTo(1);
        }
    }
}
