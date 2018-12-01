// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(547,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_TEXTUREGETSURFDATA
    {
        public IntPtr dwhContext;
        public IntPtr lpDDS;
        public uint dwHandle;
        public HRESULT ddrval;
    }
}
