// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1674,9)
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
