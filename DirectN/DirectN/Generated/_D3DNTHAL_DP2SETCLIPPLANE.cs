// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dnthal.h(818,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2SETCLIPPLANE
    {
        public uint dwIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] plane;
    }
}
