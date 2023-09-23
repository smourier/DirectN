// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_USERMODESUBMISSION_CAPS
    {
        public _DXGK_USERMODESUBMISSION_CAPS__union_0 Flags;
        public uint DoorbellSizeInBytes;
        public uint SecondaryDoorbellSizeInBytes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Reserved;
    }
}
