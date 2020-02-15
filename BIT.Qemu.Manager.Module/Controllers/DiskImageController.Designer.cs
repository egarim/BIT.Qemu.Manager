namespace BIT.Qemu.Manager.Module.Controllers
{
    partial class DiskImageController
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
            this.components = new System.ComponentModel.Container();
            this.InitizalizeDiskImage = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // InitizalizeDiskImage
            // 
            this.InitizalizeDiskImage.Caption = "Initialize Disk Image";
            this.InitizalizeDiskImage.ConfirmationMessage = null;
            this.InitizalizeDiskImage.Id = "95c53cd7-97ed-4508-a016-e3264c1a596b";
            this.InitizalizeDiskImage.ToolTip = null;
            this.InitizalizeDiskImage.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.InitizalizeDiskImage_Execute);
            // 
            // DiskImageController
            // 
            this.Actions.Add(this.InitizalizeDiskImage);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction InitizalizeDiskImage;
    }
}
