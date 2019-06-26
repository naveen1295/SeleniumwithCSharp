using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

namespace Seleniumwithcsharp.Helpers
{
    class LogTest
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(LogTest));

    }
}
