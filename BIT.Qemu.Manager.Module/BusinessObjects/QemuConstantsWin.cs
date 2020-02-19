using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT.Qemu.Manager.Module.BusinessObjects
{
    public class QemuConstantsWin
    {

        public QemuConstantsWin()
        {
            this.QemuImage = "qemu-img.exe";
        }
        string _qemuImage;

        public string QemuImage
        {
            get { return _qemuImage; }
            set
            {
                _qemuImage = value;
            }
        }
        
    }
}
