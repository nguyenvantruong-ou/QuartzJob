
namespace Quartz.NET.Controllers
{
    public class QuartzJob : IJob
    {
        private readonly ILogger<QuartzJob> _logger;

        public QuartzJob(ILogger<QuartzJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("LogJob executed at: _+_ {time}", DateTimeOffset.Now);
            return Task.CompletedTask;
        }
    }
}
