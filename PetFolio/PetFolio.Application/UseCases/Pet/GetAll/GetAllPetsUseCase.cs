using PetFolio.Communication.Enums;
using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Buddy",
                        Type = PetType.Dog
                    },
                    new ResponseShortPetJson
                    {
                        Id = 2,
                        Name = "Mittens",
                        Type = PetType.Cat
                    }
                }
            };
        }
    }
}
