// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1739,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_CPDRIVERNAME
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string ContentProtectionFileName;
    }
}
