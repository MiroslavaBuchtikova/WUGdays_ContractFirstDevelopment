using Microsoft.AspNetCore.Mvc;
using Petstore.v1.Controllers;
using Petstore.v1.Models;

namespace ContractFirstApi.Controllers.V1
{
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    public class Controller : PetsApiController
    {
        public override IActionResult CreatePets()
        {
            throw new NotImplementedException();
        }

        public override IActionResult ListPets(int? limit)
        {
            return Ok(new List<Pet>());
        }

        public override IActionResult ShowPetById(string petId)
        {
            throw new NotImplementedException();
        }
    }
}