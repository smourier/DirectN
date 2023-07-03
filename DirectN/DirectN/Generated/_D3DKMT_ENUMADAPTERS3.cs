// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(2458,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ENUMADAPTERS3
    {
        public _D3DKMT_ENUMADAPTERS_FILTER Filter;
        public uint NumAdapters;
        public IntPtr pAdapters;
    }
}
