// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5970,9)
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
