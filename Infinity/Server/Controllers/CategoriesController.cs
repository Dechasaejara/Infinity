using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : EFBaseController<Category, InfinityDbContext>
    {
        EFGenericRepository<Category, InfinityDbContext> repository;

        public CategoriesController(EFGenericRepository<Category, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
