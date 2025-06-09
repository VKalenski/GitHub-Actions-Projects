#region Usings
using Microsoft.AspNetCore.Mvc;
using RedisAPI.Data;
using RedisAPI.Models;
#endregion

namespace RedisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        #region Fields
        private readonly IPlatformRepo _repository;
        #endregion

        #region Ctor
        public PlatformsController(IPlatformRepo repository)
        {
            _repository = repository;
        }
        #endregion

        #region GET
        [HttpGet]
        public ActionResult<IEnumerable<Platform>> GetPlatforms()
        {
            return Ok(_repository.GetAllPlatforms());
        }

        [HttpGet("{id}", Name = "GetPlatformById")]
        public ActionResult<IEnumerable<Platform>> GetPlatformById(string id)
        {

            var platform = _repository.GetPlatformById(id);

            if (platform != null)
            {
                return Ok(platform);
            }

            return NotFound();
        }
        #endregion

        #region POST
        [HttpPost]
        public ActionResult<Platform> CreatePlatform(Platform platform)
        {
            _repository.CreatePlatform(platform);

            return CreatedAtRoute(nameof(GetPlatformById), new { Id = platform.Id }, platform);
        }
        #endregion
    }
}