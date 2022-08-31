using Microsoft.AspNetCore.Mvc;

using ContractFirstApi.Petstore.v2;

namespace ContractFirstApi.Controllers.V2
{
    [ApiExplorerSettings(GroupName = "v2")]
    public class Controller : Petstore.v2.ControllerBase
    {
        public override Task CreatePets([Microsoft.AspNetCore.Mvc.FromQuery] int ownerId)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<Pet>> ListPets([Microsoft.AspNetCore.Mvc.FromQuery] int? limit, [Microsoft.AspNetCore.Mvc.FromQuery] bool displayOwnerInfo)
        {
            throw new NotImplementedException();
        }

        public override Task<Pet> ShowPetById(string petId)
        {
            throw new NotImplementedException();
        }
    }
}