// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1846,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DXVAHD_SETVIDEOPROCESSBLTSTATE
    {
        public IntPtr hVideoProcessor;
        public _DXVAHDDDI_BLT_STATE State;
        public uint DataSize;
        public IntPtr pData;
    }
}
