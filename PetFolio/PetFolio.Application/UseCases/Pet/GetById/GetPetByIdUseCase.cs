using PetFolio.Communication.Enums;
using PetFolio.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFolio.Application.UseCases.Pet.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Fido",
                Birthday = new DateTime(year:2020, month:1, day:01),
                Type = PetType.Dog
            };
        }
    }
}
