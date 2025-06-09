#region Usings
using System.ComponentModel.DataAnnotations;
#endregion

namespace RedisAPI.Models
{
    public class Platform
    {
        [Required]
        public string Id { get; set; } = $"platform:{Guid.NewGuid().ToString()}";

        [Required]
        public string Name { get; set; } = String.Empty;
    }
}
