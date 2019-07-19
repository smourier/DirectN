// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(1962,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_CREATESURFACEEXDATA
    {
        public uint dwFlags;
        public IntPtr lpDDLcl;
        public IntPtr lpDDSLcl;
        public HRESULT ddRVal;
    }
}
