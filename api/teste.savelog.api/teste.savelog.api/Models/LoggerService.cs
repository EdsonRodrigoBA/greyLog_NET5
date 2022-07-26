using Microsoft.Extensions.Logging;
using Serilog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.savelog.api.Models
{
    public class LoggerService : ILoggerService
    {

        private readonly ILogger<LoggerService> _logger;

        public LoggerService(ILogger<LoggerService> logger)
        {
            _logger = logger;
        }
        public async Task LogInformation(LoggerRequest request)
        {
            var date = DateTime.UtcNow;
            using (LogContext.PushProperty("ApplicationName", request.ApplicationName))
            using (LogContext.PushProperty("LogMessage", request.Message))
            using (LogContext.PushProperty("Date", date))
            {
                await Task.Run(() => _logger.LogWarning($"Log Level Information ApplicationName: {request.ApplicationName} - LogMesage: {request.Message} - Date: {date}"));
            }


        }

        public async Task LogWarning(LoggerRequest request)
        {
            var date = DateTime.UtcNow;
            using (LogContext.PushProperty("ApplicationName", request.ApplicationName))
            using (LogContext.PushProperty("LogMessage", request.Message))
            using (LogContext.PushProperty("Date", date))
            {
                await Task.Run(() => _logger.LogWarning($"Log Level Warning ApplicationName: {request.ApplicationName} - LogMesage: {request.Message} - Date: {date}"));
            }
        }
        public async Task LogError(LoggerRequest request)
        {
            var date = DateTime.UtcNow;
            using (LogContext.PushProperty("ApplicationName", request.ApplicationName))
            using (LogContext.PushProperty("LogMessage", request.Message))
            using (LogContext.PushProperty("InnerMessage", request.InnerException))
            using (LogContext.PushProperty("StackTracer", request.StackTracer))
            using (LogContext.PushProperty("Date", date))
            {
                await Task.Run(() => _logger.LogWarning($"Log Level Error ApplicationName: {request.ApplicationName} - LogMesage: {request.Message} - InnerException:{request.InnerException} - StackTracer:{request.StackTracer} - Date: {date}"));
            }
        }




    }
}
