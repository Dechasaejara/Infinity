using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : EFBaseController<User, InfinityDbContext>
    {
        EFGenericRepository<User, InfinityDbContext> repository;

        public UsersController(EFGenericRepository<User, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
