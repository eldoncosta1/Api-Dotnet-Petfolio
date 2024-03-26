﻿using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets =
            [
                new ResponseShortPetsJson
                {
                    Id = 1,
                    Name = "Dog",
                },
                new ResponseShortPetsJson
                {
                    Id = 2,
                    Name = "Cat",
                },
            ],
        };
    }
}
