using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.IO;
using System.Linq;

namespace BIT.Qemu.Manager.Module.BusinessObjects
{

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
            Settings settings = Settings.GetInstance(this.Session);
            this.DiskImageType = DiskImageType.Qcow2;
            this.DiskSizeUnitOfMeasure = UnitOfMeasure.GigaBytes;
            this.Size = 10;
            this.Initialized = false;
            this.FilePath = settings.UnboundDiskFolder;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string _filePath;
        bool _initialized;
        UnitOfMeasure _diskSizeUnitOfMeasure;
        double _size;
        DiskImageType diskImageType;
        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }
        
        [Size(300)]
        public string FilePath
        {
            get => _filePath;
            set => SetPropertyValue(nameof(FilePath), ref _filePath, value);
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

        public UnitOfMeasure DiskSizeUnitOfMeasure
        {
            get => _diskSizeUnitOfMeasure;
            set => SetPropertyValue(nameof(DiskSizeUnitOfMeasure), ref _diskSizeUnitOfMeasure, value);
        }
        
        public bool Initialized
        {
            get => _initialized;
            private set => SetPropertyValue(nameof(Initialized), ref _initialized, value);
        }
        public void Initialize()
        {
            //qemu-img create -f qcow2 -o size=10G ubuntu.img
            QemuConstantsWin qemuConstantsWin = new QemuConstantsWin();
            Settings settings = Settings.GetInstance(this.Session);
            var QemuImage= Path.Combine(settings.QemuPath, qemuConstantsWin.QemuImage);
            string DiskFilePath = $"{Name}.{this.DiskImageType.ToParameter()}";

            string FullPath = Path.Combine(settings.UnboundDiskFolder, DiskFilePath);

                string arguments = $"create -f {this.DiskImageType.ToParameter()} -o size={this.Size}{this.DiskSizeUnitOfMeasure.ToParameter()} {FullPath}";
            ProcessStarter.ExecuteProcess(QemuImage, arguments);

        }

    }
}