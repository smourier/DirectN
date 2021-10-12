// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2061,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_GPUVERSION
    {
        public uint PhysicalAdapterIndex;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string BiosVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string GpuArchitecture;
    }
}
