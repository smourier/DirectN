// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(2220,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_VGPUINTERFACEID
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string VirtualGpuIntefaceId;
    }
}
