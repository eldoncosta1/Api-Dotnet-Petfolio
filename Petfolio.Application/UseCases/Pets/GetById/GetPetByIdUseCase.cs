using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = 1,
            Name = "Dog",
            Birthday = DateTime.Now,
            Type = PetTypeEnum.Dog,
        };
    }
}
