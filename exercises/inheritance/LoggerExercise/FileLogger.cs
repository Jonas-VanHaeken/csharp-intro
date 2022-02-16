using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    internal class FileLogger : StreamLogger
    {
        private FileStream writer;

        public FileLogger(FileStream writer) : base(new StreamWriter(writer))
        {
            this.writer = writer;
        }

        public static FileLogger Create(string filename)
        {
            var stream = File.OpenWrite(filename);
            return new FileLogger(stream);
        }

        public override void Close()
        {
            writer.Close();
        }
    }
}
