using DataTrack.Service.Interrogator;
using System.ServiceProcess;

namespace DataTrack.Service
{
    public partial class DTInterrogator : ServiceBase
    {
        public DTInterrogator()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var shell = new Shell();
            shell.StartWatching();
        }

        protected override void OnStop()
        {
        }
    }
}
