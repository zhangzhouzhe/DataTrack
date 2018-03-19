namespace DataTrack.Service
{ 
    partial class DTnterrogationInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTInterrogatorInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.DTInterrogator = new System.ServiceProcess.ServiceInstaller();
            // 
            // DTInterrogatorInstaller
            // 
            this.DTInterrogatorInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.DTInterrogatorInstaller.Password = null;
            this.DTInterrogatorInstaller.Username = null;
            // 
            // DTInterrogator
            // 
            this.DTInterrogator.DisplayName = "DTInterrogator";
            this.DTInterrogator.ServiceName = "DTInterrogator";
            this.DTInterrogator.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // DTnterrogationInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.DTInterrogatorInstaller,
            this.DTInterrogator});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller DTInterrogatorInstaller;
        private System.ServiceProcess.ServiceInstaller DTInterrogator;
    }
}