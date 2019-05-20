// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7676,9)
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
