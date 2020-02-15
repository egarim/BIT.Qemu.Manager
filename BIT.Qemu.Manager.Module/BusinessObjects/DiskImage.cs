﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace BIT.Qemu.Manager.Module.BusinessObjects
{

    public enum DiskSizeUnitOfMeasure
    {
        KiloBytes=0,
        MegaBytes=1,
        GigaBytes=2,
        TeraBytes=3,
        PetaBytes=4,
        ExaBytes=5


       
    }

    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class DiskImage : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DiskImage(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.DiskImageType = DiskImageType.Qcow2;
            this.DiskSizeUnitOfMeasure = DiskSizeUnitOfMeasure.GigaBytes;
            this.Size = 10;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        DiskSizeUnitOfMeasure _diskSizeUnitOfMeasure;
        double _size;
        DiskImageType diskImageType;
        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        public DiskImageType DiskImageType
        {
            get => diskImageType;
            set => SetPropertyValue(nameof(DiskImageType), ref diskImageType, value);
        }

        public double Size
        {
            get => _size;
            set => SetPropertyValue(nameof(Size), ref _size, value);
        }
        
        public DiskSizeUnitOfMeasure DiskSizeUnitOfMeasure
        {
            get => _diskSizeUnitOfMeasure;
            set => SetPropertyValue(nameof(DiskSizeUnitOfMeasure), ref _diskSizeUnitOfMeasure, value);
        }

    }
}