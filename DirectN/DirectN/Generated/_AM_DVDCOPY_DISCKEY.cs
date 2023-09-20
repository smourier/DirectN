// generated from <Windows SDK Path>\um\dvdmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_DVDCOPY_DISCKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)] 
        public byte[] DiscKey;
    }
}
