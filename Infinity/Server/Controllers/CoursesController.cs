using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : EFBaseController<Course, InfinityDbContext>
    {
        EFGenericRepository<Course, InfinityDbContext> repository;

        public CoursesController(EFGenericRepository<Course, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
