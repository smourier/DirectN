// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CANCELFLIPS_PLANE
    {
        public ulong PresentIdCancelRequested;
        public ulong PresentIdCancelled;
        public uint LayerIndex;
    }
}
