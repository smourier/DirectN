// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_DISCONNECTDOORBELL
    {
        public IntPtr hHwQueue;
        public IntPtr hDoorbell;
        public _DXGKARGCB_DISCONNECTDOORBELL_FLAGS Flags;
        public _D3DDDI_DOORBELLSTATUS DisconnectReason;
    }
}
