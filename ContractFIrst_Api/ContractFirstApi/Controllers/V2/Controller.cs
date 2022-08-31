using Microsoft.AspNetCore.Mvc;
using Petstore.v2.Controllers;

namespace ContractFirstApi.Controllers.V2
{
    [ApiExplorerSettings(GroupName = "v2")]
    public class Controller : PetsApiController
    {
        public override IActionResult CreatePets(int ownerId)
        {
            throw new NotImplementedException();
        }

        public override IActionResult ListPets(bool displayOwnerInfo, int? limit)
        {
            throw new NotImplementedException();
        }

        public override IActionResult ShowPetById(string petId)
        {
            throw new NotImplementedException();
        }
    }
}