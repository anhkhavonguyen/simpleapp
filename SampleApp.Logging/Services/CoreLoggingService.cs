﻿using SampleApp.Logging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Logging.Services
{
    public class CoreLoggingService : BaseService, ILoggingService
    {
        public CoreLoggingService()
        {

        }

        public void LogCoreError(LogErrorRequest request)
        {
            base.LogError(request);
        }
    }
}
