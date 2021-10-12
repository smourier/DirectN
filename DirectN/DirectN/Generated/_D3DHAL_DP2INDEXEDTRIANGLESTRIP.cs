// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(1051,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2INDEXEDTRIANGLESTRIP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public ushort[] wV;
    }
}
