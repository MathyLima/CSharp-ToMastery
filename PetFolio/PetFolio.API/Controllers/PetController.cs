using Microsoft.AspNetCore.Mvc;
using PetFolio.Application.UseCases.Pet.Delete;
using PetFolio.Application.UseCases.Pet.GetAll;
using PetFolio.Application.UseCases.Pet.GetById;
using PetFolio.Application.UseCases.Pet.Register;
using PetFolio.Application.UseCases.Pet.Update;
using PetFolio.Communication.Requests;
using PetFolio.Communication.Responses;

namespace PetFolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
        {
            var useCase = new UpdatePetUseCase();
            useCase.Execute(id, request);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJson),StatusCodes.Status200OK)]
        [ProducesResponseType( StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllPetsUseCase();
            var response = useCase.Execute();
            if(response.Pets.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var useCase = new GetPetByIdUseCase();
            var response = useCase.Execute(id);
            return Ok(response);
          
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            var useCase = new DeletePetByIdUseCase();
            useCase.Execute(id);
            return NoContent();
        }

    }
}
