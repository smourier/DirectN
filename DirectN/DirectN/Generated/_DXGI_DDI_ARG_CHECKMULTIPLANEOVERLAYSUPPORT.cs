// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_CHECKMULTIPLANEOVERLAYSUPPORT
    {
        public ulong hDevice;
        public int VidPnSourceId;
        public uint NumPlaneInfo;
        public IntPtr pPlaneInfo;
        public bool Supported;
    }
}
