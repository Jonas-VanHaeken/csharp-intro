using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    internal class StreamLogger : Logger
    {
        private StreamWriter writer;

        public StreamLogger(StreamWriter writer)
        {
            this.writer = writer;
        }

        public override void Log(string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }
    }
}
