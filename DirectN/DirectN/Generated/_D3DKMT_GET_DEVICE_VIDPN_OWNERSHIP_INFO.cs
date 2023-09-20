// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
