using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolutionsController : EFBaseController<Solution, InfinityDbContext>
    {
        EFGenericRepository<Solution, InfinityDbContext> repository;

        public SolutionsController(EFGenericRepository<Solution, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
