using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemExercise
{
    internal class ChangedFilesCounter
    {
        public int ChangeCount { get; set; }
        private List<string> changedFiles;
        
        public ChangedFilesCounter(IFileSystem fs)
        {
            changedFiles = new List<string>();
            fs.FileCreated += OnFileChange;
            fs.FileDeleted += OnFileChange;
            fs.FileWritten += OnFileChange;
        }

        public void OnFileChange(string path)
        {
            if (!changedFiles.Contains(path))
            {
                changedFiles.Add(path);
                ChangeCount++;
            }
        }

    }
}
