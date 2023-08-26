using Infinity.Server.Data;
using Infinity.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Infinity.Server.Controllers
{
    public class EFBaseController<TEntity, TDataContext> : ControllerBase where TEntity : class where TDataContext : DbContext
    {
        private EFGenericRepository<TEntity, TDataContext> repository;

        public EFBaseController(EFGenericRepository<TEntity, TDataContext> _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public async Task<ActionResult<APIListResponse<TEntity>>> GetAll()
        {
            try
            {
                var result = await repository.GetAll();
                return Ok(new APIListResponse<TEntity>()
                {
                    Success = true,
                    Data = result
                });
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpGet("{PropertyName}/{Value}/GetByValue")]
        public async Task<ActionResult<APISingleResponse<TEntity>>> GetByValue(string PropertyName, string Value)
        {

            await Task.Delay(0);
            try
            {
                var IdProperty = typeof(TEntity).GetProperty(PropertyName);
                var result = (from x in repository.dbSet.ToList()
                              where IdProperty.GetValue(x).ToString().ToLower() == Value.ToLower()
                              select x).FirstOrDefault();
                if (result != null)
                {
                    return Ok(new APISingleResponse<TEntity>()
                    {
                        Success = true,
                        Data = result
                    });
                }
                else
                {
                    return Ok(new APISingleResponse<TEntity>()
                    {
                        Success = false,
                        ErrorMessages = new List<string>() { "Entity Not Found" },
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpGet("{PropertyName}/{Value}/SearchByValue")]
        public async Task<ActionResult<APIListResponse<TEntity>>> SearchByValue(string PropertyName, string Value)
        {
            await Task.Delay(0);
            try
            {
                var IdProperty = typeof(TEntity).GetProperty(PropertyName);
                var result = from x in repository.dbSet.ToList()
                             where IdProperty.GetValue(x).ToString().ToLower().Contains(Value.ToLower())
                             select x;
                if (result != null)
                {
                    return Ok(new APIListResponse<TEntity>()
                    {
                        Success = true,
                        Data = result
                    });
                }
                else
                {
                    return Ok(new APIListResponse<TEntity>()
                    {
                        Success = false,
                        ErrorMessages = new List<string>() { "No Entities Found" },
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult<APISingleResponse<TEntity>>> Post([FromBody] TEntity Entity)
        {
            try
            {
                await repository.Insert(Entity);
                return Ok(new APISingleResponse<TEntity>()
                {
                    Success = true,
                    Data = Entity
                });
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult<APISingleResponse<TEntity>>> Put([FromBody] TEntity Entity)
        {
            try
            {
                await repository.Update(Entity);
                return Ok(new APISingleResponse<TEntity>()
                {
                    Success = true,
                    Data = Entity
                });
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpDelete("{PropertyName}/{Value}/DeleteByValue")]
        public async Task<ActionResult> DeleteByValue(string PropertyName, string Value)
        {
            try
            {
                var IdProperty = typeof(TEntity).GetProperty(PropertyName);
                var entity = (from x in repository.dbSet.ToList()
                              where IdProperty.GetValue(x).ToString() == Value
                              select x).FirstOrDefault();

                if (entity != null)
                {
                    await repository.Delete(entity);
                    return NoContent();
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                // log exception here
                var msg = ex.Message;
                return StatusCode(500);
            }
        }
    }
}
