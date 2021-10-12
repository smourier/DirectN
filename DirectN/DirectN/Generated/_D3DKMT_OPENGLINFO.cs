// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(1646,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_OPENGLINFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string UmdOpenGlIcdFileName;
        public uint Version;
        public uint Flags;
    }
}
