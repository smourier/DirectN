// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dhal.h(1183,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2SETCLIPPLANE
    {
        public uint dwIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public D3DVALUE[] plane;
    }
}
