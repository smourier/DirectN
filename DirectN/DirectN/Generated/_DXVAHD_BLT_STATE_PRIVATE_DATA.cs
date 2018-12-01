// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(373,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_BLT_STATE_PRIVATE_DATA
    {
        public Guid Guid;
        public uint DataSize;
        public IntPtr pData;
    }
}
