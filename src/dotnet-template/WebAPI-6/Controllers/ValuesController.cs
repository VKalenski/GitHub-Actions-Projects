#region Usings
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        #region GET
        [HttpGet("get")]
        // [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1: 1", "value2: 2" };
        }

        [HttpGet("{id}")]
        // [Authorize]
        public string Get(int id)
        {
            return "value";
        }
        #endregion

        #region POST
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        #endregion

        #region PUT
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        #endregion

        #region DELETE
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
        #endregion
    }
}
