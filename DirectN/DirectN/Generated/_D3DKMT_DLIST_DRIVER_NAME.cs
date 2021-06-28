// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1734,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_DLIST_DRIVER_NAME
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string DListFileName;
    }
}
