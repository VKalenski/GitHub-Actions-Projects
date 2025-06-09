using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebAPI_7.HealthChecks
{
    public class MyHealthCheck : IHealthCheck
    {
        private Random _random = new Random();

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var responseTime = _random.Next(1, 300);

            if (responseTime < 100)
            {
                return Task.FromResult(HealthCheckResult.Healthy("Healthy result from MyHealthCheck"));
            }
            else if (responseTime >= 100 && responseTime <= 200)
            {
                return Task.FromResult(HealthCheckResult.Degraded("Degraded result from MyHealthCheck"));
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Unhealthy result from MyHealthCheck"));
            }            
        }
    }
}
