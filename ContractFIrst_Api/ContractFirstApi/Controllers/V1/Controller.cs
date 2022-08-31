//using Microsoft.AspNetCore.Mvc;

using ContractFirstApi.Petstore.v1;
using Microsoft.AspNetCore.Mvc;

namespace ContractFirstApi.Controllers.V1
{
    [ApiExplorerSettings(GroupName = "v1")]
    public class Controller : Petstore.v1.ControllerBase
    {
        public override Task CreatePets()
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<Pet>> ListPets([Microsoft.AspNetCore.Mvc.FromQuery] int? limit)
        {
            throw new NotImplementedException();
        }

        public override Task<Pet> ShowPetById(string petId)
        {
            throw new NotImplementedException();
        }
    }
}