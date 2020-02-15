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
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class VirtualMachine : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public VirtualMachine(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.Memory = 2048;
            this.MemoryUnitOfMeasure = UnitOfMeasure.MegaBytes;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        UnitOfMeasure _memoryUnitOfMeasure;
        int _memory;
        string _name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => _name;
            set => SetPropertyValue(nameof(Name), ref _name, value);
        }
        [Association("VirtualMachine-VirtualMachineDiskImages")]
        public XPCollection<VirtualMachineDiskImage> VirtualMachineDiskImages
        {
            get
            {
                return GetCollection<VirtualMachineDiskImage>(nameof(VirtualMachineDiskImages));
            }
        }

        public int Memory
        {
            get => _memory;
            set => SetPropertyValue(nameof(Memory), ref _memory, value);
        }
        
        public UnitOfMeasure MemoryUnitOfMeasure
        {
            get => _memoryUnitOfMeasure;
            set => SetPropertyValue(nameof(MemoryUnitOfMeasure), ref _memoryUnitOfMeasure, value);
        }
    }
}