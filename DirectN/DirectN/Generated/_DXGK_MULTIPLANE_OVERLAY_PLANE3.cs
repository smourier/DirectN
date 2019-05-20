// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5469,9)
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
