// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_VIDPNSOURCE_INFORMATION
    {
        public _D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE_INFORMATION GlobalInformation;
        public _D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE_INFORMATION SystemInformation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] Reserved;
    }
}
