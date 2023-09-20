// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
