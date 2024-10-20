// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_TDR_PAYLOAD_VSYNC_TIMEOUT
    {
        public uint VidPnSourceId;
        public uint LayerIndex;
        public ulong PresentId;
    }
}
