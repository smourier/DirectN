// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDPNSOURCEADDRESSWITHMULTIPLANEOVERLAY3
    {
        public uint VidPnSourceId;
        public _DXGK_SETVIDPNSOURCEADDRESS_INPUT_FLAGS InputFlags;
        public _DXGK_SETVIDPNSOURCEADDRESS_OUTPUT_FLAGS OutputFlags;
        public uint PlaneCount;
        public IntPtr ppPlanes;
        public IntPtr pPostComposition;
        public uint Duration;
        public IntPtr pHDRMetaData;
        public ulong TargetFlipTime;
    }
}
