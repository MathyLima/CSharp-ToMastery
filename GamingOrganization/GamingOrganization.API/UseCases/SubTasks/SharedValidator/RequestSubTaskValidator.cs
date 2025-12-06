using FluentValidation;
using GammingOrganization.Communication.Requests.UserTask;

namespace GamingOrganization.API.UseCases.SharedValidator
{
    public class RequestSubTaskValidator:AbstractValidator<RequestSubTaskJson>
    {
        public RequestSubTaskValidator() { 
            RuleFor(st=> st.Title).NotEmpty().WithMessage("Sua subtarefa deve conter um título");
            RuleFor(st => st.Description).NotEmpty().WithMessage("Deve conter ao menos uma pequena descrição");
            RuleFor(st=> st.Order).GreaterThanOrEqualTo(0).WithMessage("Sua tarefa deve estar ao menos na posição 0");
        }
    }
}
