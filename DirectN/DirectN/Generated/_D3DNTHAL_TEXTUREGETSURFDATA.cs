// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(344,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_TEXTUREGETSURFDATA
    {
        public ulong dwhContext;
        public IntPtr hDDS;
        public ulong dwHandle;
        public HRESULT ddrval;
    }
}
