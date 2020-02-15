using BIT.Qemu.Manager.Module.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT.Qemu.Manager.Module.Controllers
{
   
    public class SettingsController : WindowController
    {
        public SettingsController()
        {
            //Comment out the following line if you implement this Controller for a Mobile application
            this.TargetWindowType = WindowType.Main;
            PopupWindowShowAction showSingletonAction =
                new PopupWindowShowAction(this, "ShowSettings", PredefinedCategory.View);
            showSingletonAction.CustomizePopupWindowParams += showSingletonAction_CustomizePopupWindowParams;

            showSingletonAction.Caption = "Settings";
        }
        private void showSingletonAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Settings));
            DetailView detailView = Application.CreateDetailView(objectSpace, objectSpace.GetObjects<Settings>()[0]);
            detailView.ViewEditMode = ViewEditMode.Edit;
            e.View = detailView;
        }
    }
}
