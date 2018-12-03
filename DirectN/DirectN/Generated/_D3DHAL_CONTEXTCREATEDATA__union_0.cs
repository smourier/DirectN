// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(447,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CONTEXTCREATEDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDGbl => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr lpDDLcl => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
