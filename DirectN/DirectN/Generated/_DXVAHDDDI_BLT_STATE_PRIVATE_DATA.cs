// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1718,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_BLT_STATE_PRIVATE_DATA
    {
        public Guid Guid;
        public uint DataSize;
        public IntPtr pData;
    }
}
