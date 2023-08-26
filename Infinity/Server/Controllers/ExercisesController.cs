using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : EFBaseController<Exercise, InfinityDbContext>
    {
        EFGenericRepository<Exercise, InfinityDbContext> repository;

        public ExercisesController(EFGenericRepository<Exercise, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
