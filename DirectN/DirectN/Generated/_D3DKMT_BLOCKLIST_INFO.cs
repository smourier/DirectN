// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2008,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_BLOCKLIST_INFO
    {
        public uint Size;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string BlockList;
    }
}
