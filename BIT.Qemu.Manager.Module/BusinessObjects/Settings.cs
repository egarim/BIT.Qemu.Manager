using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using System.IO;

namespace BIT.Qemu.Manager.Module.BusinessObjects
{
    [RuleObjectExists("AnotherSingletonExists", DefaultContexts.Save, "True", InvertResult = true,
    CustomMessageTemplate = "Another Singleton already exists.")]
    [RuleCriteria("CannotDeleteSingleton", DefaultContexts.Delete, "False",
    CustomMessageTemplate = "Cannot delete Singleton.")]
    public class Settings : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Settings(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.DefaultVirtualMachineFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "QemuVMs");
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string defaultVirtualMachineFolder;
        string qemuPath;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string QemuPath
        {
            get => qemuPath;
            set => SetPropertyValue(nameof(QemuPath), ref qemuPath, value);
        }
        
        [Size(300)]
        public string DefaultVirtualMachineFolder
        {
            get => defaultVirtualMachineFolder;
            set => SetPropertyValue(nameof(DefaultVirtualMachineFolder), ref defaultVirtualMachineFolder, value);
        }




    }
}