// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(2054,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public partial struct _DXGK_GPUVERSION
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string BiosVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string GpuArchitecture;
    }
}
