using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheatSheetsController : EFBaseController<CheatSheet, InfinityDbContext>
    {
        EFGenericRepository<CheatSheet, InfinityDbContext> repository;

        public CheatSheetsController(EFGenericRepository<CheatSheet, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
