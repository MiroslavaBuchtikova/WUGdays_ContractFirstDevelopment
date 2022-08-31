using Microsoft.AspNetCore.Mvc;
using Petstore.v1.Controllers;

namespace ContractFirstApi.Controllers.V1
{
    [ApiExplorerSettings(GroupName = "v1")]
    public class Controller : PetsApiController
    {
        public override IActionResult CreatePets()
        {
            throw new NotImplementedException();
        }

        public override IActionResult ListPets(int? limit)
        {
            throw new NotImplementedException();
        }

        public override IActionResult ShowPetById(string petId)
        {
            throw new NotImplementedException();
        }
    }
}