// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_PLANE3
    {
        public uint LayerIndex;
        public ulong PresentId;
        public _DXGK_PLANE_SPECIFIC_INPUT_FLAGS InputFlags;
        public _DXGK_PLANE_SPECIFIC_OUTPUT_FLAGS OutputFlags;
        public uint MaxImmediateFlipLine;
        public uint ContextCount;
        public IntPtr ppContextData;
        public uint DriverPrivateDataSize;
        public IntPtr pDriverPrivateData;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES3 PlaneAttributes;
    }
}
