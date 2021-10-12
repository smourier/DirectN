// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3818,9)
using System;
using System.Runtime.InteropServices;
using D3DDDI_VIDEO_PRESENT_SOURCE_ID = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETVIDPNSOURCEOWNER
    {
        public uint hDevice;
        public IntPtr pType;
        public IntPtr pVidPnSourceId;
        public uint VidPnSourceCount;
    }
}
