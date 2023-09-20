// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CROSSBAR_PININFO_S
    {
        public KSIDENTIFIER Property;
        public KSPIN_DATAFLOW Direction;
        public uint Index;
        public uint PinType;
        public uint RelatedPinIndex;
        public KSIDENTIFIER Medium;
    }
}
