using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace DataTrack.Service
{
    [RunInstaller(true)]
    public partial class DTnterrogationInstaller : System.Configuration.Install.Installer
    {
        public DTnterrogationInstaller()
        {
            InitializeComponent();
        }
    }
}
