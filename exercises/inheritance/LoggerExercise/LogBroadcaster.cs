using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    internal class LogBroadcaster : Logger
    {
        private readonly IList<Logger> loggers;

        public LogBroadcaster(IEnumerable<Logger> loggers)
        {
            this.loggers = loggers.ToList();
        }

        public override void Log(string message)
        {
            foreach(Logger logger in loggers)
            {
              logger.Log(message);
            }
        }

        public override void Close()
        {
            foreach(Logger log in loggers)
            {
                log.Close();
            }
        }
    }
}
