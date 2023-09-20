// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_OMAC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] abOMAC;
    }
}
