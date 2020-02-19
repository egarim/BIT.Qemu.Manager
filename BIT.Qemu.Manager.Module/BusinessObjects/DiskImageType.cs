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
    public enum DiskImageType
    {
        Raw=0,
        Qcow2=1,
        Qed=2,
        Qcow=3,
        Vmdk=4,
        Vdi=5,
        Vpc=6,
       
    }
    static class DiskImageTypeExtensions
    {
        public static string ToParameter(this DiskImageType DiskImageType)
        {
            return DiskImageType.ToString().ToLower();
        }
    }
}