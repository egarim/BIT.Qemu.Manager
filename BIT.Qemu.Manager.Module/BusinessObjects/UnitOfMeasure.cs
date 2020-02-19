using System;
using System.Linq;

namespace BIT.Qemu.Manager.Module.BusinessObjects
{
    public enum UnitOfMeasure

    {   Byte=-1,
        KiloBytes = 0,
        MegaBytes = 1,
        GigaBytes = 2,
        TeraBytes = 3,
        PetaBytes = 4,
        ExaBytes = 5



    }
    static class UnitOfMeasureExtensions
    {
        public static string ToParameter(this UnitOfMeasure UnitOfMeasure)
        {
            switch (UnitOfMeasure)
            {
                case UnitOfMeasure.Byte:
                    return "b";
                case UnitOfMeasure.KiloBytes:
                    return "k";
                case UnitOfMeasure.MegaBytes:
                    return "M";
                case UnitOfMeasure.GigaBytes:
                    return "G";
                case UnitOfMeasure.TeraBytes:
                    return "T";
                case UnitOfMeasure.PetaBytes:
                    return "P";
                case UnitOfMeasure.ExaBytes:
                    return "E";
            }
            return "";
        }
    }
}