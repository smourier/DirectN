// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_HISTORY_BUFFER
    {
        public _DXGK_HISTORY_BUFFER_HEADER Header;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] DriverPrivateData;
    }
}
