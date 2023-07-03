// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ks.h(1782,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSALLOCATOR_FRAMING_EX
    {
        public uint CountItems;
        public uint PinFlags;
        public KS_COMPRESSION OutputCompression;
        public uint PinWeight;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public KS_FRAMING_ITEM[] FramingItem;
    }
}
