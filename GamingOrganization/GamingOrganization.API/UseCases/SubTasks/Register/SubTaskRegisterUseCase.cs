using GamingOrganization.API.Entities;
using GamingOrganization.API.UseCases.SharedValidator;
using GamingOrganization.Exceptions.ExceptionsBase;
using GammingOrganization.Communication.Requests.UserTask;
using GammingOrganization.Communication.Responses.SubTask;

namespace GamingOrganization.API.UseCases.SubTasks.Register
{
    public class SubTaskRegisterUseCase
    {
        public ResponseShorSubTaskJson Execute(RequestSubTaskJson request)
        {
            Validate(request);
            var entity = new SubTask
            {
                Title = request.Title,
                Description = request.Description,
                Order = request.Order,
            };
            return new ResponseShorSubTaskJson
            {
                Id = entity.Id,
                Title = entity.Title,
            };

        }
        private void Validate(RequestSubTaskJson request)
        {
            var validator = new RequestSubTaskValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errors);
            }


        }
    }
}
