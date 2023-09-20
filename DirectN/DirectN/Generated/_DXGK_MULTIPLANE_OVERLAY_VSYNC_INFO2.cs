// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_VSYNC_INFO2
    {
        public uint LayerIndex;
        public ulong PresentId;
        public _DXGKCB_NOTIFY_MPO_VSYNC_FLAGS Flags;
    }
}
