// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(2012,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDP_PTRSTRIDE
    {
        public IntPtr lpvData;
        public uint dwStride;
    }
}
