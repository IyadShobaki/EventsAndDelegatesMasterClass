using System;
using System.Threading;

namespace ConsoleUI
{
    public class FileEventArgs : EventArgs
    {
        public File File { get; set; }

    }
    public class DownloadHelper
    {
        // 1. Define a delegate
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        // 2. Create an event
        public event FileDownloadedEventHandler FileDownloaded;

        // 3.1 Prepare to raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs{ File = file});
            }
        }
        public void Download(File file)
        {
            Console.WriteLine("Downloading the file...");
            Thread.Sleep(3000);
            // 3.2 Raise the event
            OnFileDownloaded(file);
        }
    }
}
