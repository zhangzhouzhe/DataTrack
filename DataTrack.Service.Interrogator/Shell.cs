using System.IO;

namespace DataTrack.Service.Interrogator
{
    public class Shell
    {
        private FileSystemWatcher _watcher;

        public void StartWatching()
        {
            _watcher = new FileSystemWatcher()
            {
                Path = @"C:\DataTrack",
                Filter = "*.csv",
                EnableRaisingEvents = true
            };
            _watcher.Created += this.Watcher_FileModified;
        }
        private void Watcher_FileModified(object sender, FileSystemEventArgs e)
        {
            var filePath = e.FullPath;
            var filename = e.Name;
            File.Move(filePath, Path.Combine(string.Format("{0}{1}", Path.GetDirectoryName(filePath), "Archive"), filename));
        }
    }
}
