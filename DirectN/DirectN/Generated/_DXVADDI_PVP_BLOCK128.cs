// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1128,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_PVP_BLOCK128
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Data;
    }
}
