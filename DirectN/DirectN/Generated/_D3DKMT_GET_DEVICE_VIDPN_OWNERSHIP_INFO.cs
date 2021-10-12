// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(1998,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GET_DEVICE_VIDPN_OWNERSHIP_INFO
    {
        public uint hDevice;
        public byte bFailedDwmAcquireVidPn;
    }
}
