using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DataTrack.Service.Interrogator
{
    public partial class DTInterrogator : ServiceBase
    {
        private FileSystemWatcher _watcher;
        public DTInterrogator()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
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

        protected override void OnStop()
        {
        }
    }
}
