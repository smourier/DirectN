// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2737,9)
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
