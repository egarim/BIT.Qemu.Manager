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

namespace BIT.Qemu.Manager.Module.BusinessObjects
{
   
    public class VirtualMachineDiskImage : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public VirtualMachineDiskImage(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        VirtualMachine virtualMachine;

        [Association("VirtualMachine-VirtualMachineDiskImages")]
        public VirtualMachine VirtualMachine
        {
            get => virtualMachine;
            set => SetPropertyValue(nameof(VirtualMachine), ref virtualMachine, value);
        }
    }
}