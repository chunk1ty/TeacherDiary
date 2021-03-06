﻿using System;

using Common.Logging;

using TeachersDiary.Services.Contracts;

namespace TeachersDiary.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly ILog _logger = LogManager.GetLogger<LoggingService>();

        public void Error(string message, Exception ex)
        {
            _logger.Error(x => x(message), ex);
        }

        public void Error(Exception ex)
        {
            _logger.Error(x => x(ex.Message), ex);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Warning(string message)
        {
            _logger.Warn(message);
        }
    }
}
