// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
