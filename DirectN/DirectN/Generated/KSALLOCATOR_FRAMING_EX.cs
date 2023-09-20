// generated from <Windows SDK Path>\shared\ks.h
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
