using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HealthChecksAPI.HealthChecks
{
    public class HealthCheckAction1 : IHealthCheck
    {
        private Random _rnd = new Random();

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            int responseTimeinMS = _rnd.Next(1, 300);

            if (responseTimeinMS < 100)
                return Task.FromResult(HealthCheckResult.Healthy($"Response Time: {responseTimeinMS}"));
            else if (responseTimeinMS < 200)
                return Task.FromResult(HealthCheckResult.Degraded($"Response Time: {responseTimeinMS}"));
            else
                return Task.FromResult(HealthCheckResult.Unhealthy($"Response Time: {responseTimeinMS}"));
        }
    }
}