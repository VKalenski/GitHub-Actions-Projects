#region Usings
using RedisAPI.Models;
#endregion

namespace RedisAPI.Data
{
    public interface IPlatformRepo
    {
        void CreatePlatform(Platform plat);
        Platform? GetPlatformById(string id);
        IEnumerable<Platform?>? GetAllPlatforms();
    }
}
