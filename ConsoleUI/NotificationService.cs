using System;

namespace ConsoleUI
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Notifying user that download is done..." + e.File.Title);
        }
    }
}
