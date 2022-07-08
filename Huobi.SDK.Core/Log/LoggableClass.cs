using Huobi.SDK.Core.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.SDK.Core
{
    public abstract class LoggableClass
    {
        private static Func<ILogger> _createLoggerFunc = () => new ConsoleLogger();
        public static Func<ILogger> CreateLogger
        {
            get
            {
                return _createLoggerFunc;
            }
            set
            {
                if (value != null)
                {
                    _createLoggerFunc = value;
                }
            }
        }

        protected ILogger Logger { get; private set; } =  CreateLogger() ?? new ConsoleLogger();

        /// <summary>
        /// Sets the logger instance
        /// </summary>
        /// <param name="logger">The logger instance</param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="logger"/>Instance is null</exception>
        public void SetLogger(ILogger logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            Logger = logger;
        }
    }
}
