using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infinity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : EFBaseController<DetailNote, InfinityDbContext>
    {
        EFGenericRepository<DetailNote, InfinityDbContext> repository;

        public NotesController(EFGenericRepository<DetailNote, InfinityDbContext> _repository)
            : base(_repository)
        {
            repository = _repository;
        }

    }
}
