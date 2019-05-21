using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using System;
using System.Threading.Tasks;

namespace QuartzDemo.Job
{
    // 需要继承IJob类，quartz的特性
    public class Testjob : IJob
    {
        private readonly ILogger<Testjob> _logger;

        public Testjob(ILogger<Testjob> logger)
        {
            _logger = logger;
        }
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"{DateTime.Now.ToString()}:开始执行同步第三方数据");
            });
        }
    }
}
