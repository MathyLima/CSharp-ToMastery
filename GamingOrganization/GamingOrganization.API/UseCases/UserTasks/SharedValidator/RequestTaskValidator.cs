using FluentValidation;
using GammingOrganization.Communication.Requests.UserTask;

namespace GamingOrganization.API.UseCases.Tasks.SharedValidator
{
    public class RequestTaskValidator:AbstractValidator<RequestUserTaskJson>
    {
        public RequestTaskValidator() {
            RuleFor(task => task.Title).NotEmpty().WithMessage("A tarefa deve ter um título!");
            RuleFor(task => task.Description).NotEmpty().WithMessage("Adicione ao menos uma pequena descrição!");
            RuleFor(task => task.SubTasks).NotEmpty().WithMessage("A tarefa deve conter ao menos 1 subtarefa!");
        }
    }
}
