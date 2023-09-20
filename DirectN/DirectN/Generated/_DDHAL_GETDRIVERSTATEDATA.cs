// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETDRIVERSTATEDATA
    {
        public uint dwFlags;
        public _DDHAL_GETDRIVERSTATEDATA__union_0 __union_1;
        public IntPtr lpdwStates;
        public uint dwLength;
        public HRESULT ddRVal;
    }
}
