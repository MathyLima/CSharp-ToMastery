using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterExpenseJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ArgumentException),StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
