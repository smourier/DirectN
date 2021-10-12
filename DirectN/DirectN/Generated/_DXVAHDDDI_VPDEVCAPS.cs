// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2563,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_VPDEVCAPS
    {
        public uint Reserved;
        public uint DeviceCaps;
        public uint FeatureCaps;
        public uint FilterCaps;
        public uint InputFormatCaps;
        public _D3DDDI_POOL InputPool;
        public uint OutputFormatCount;
        public uint InputFormatCount;
        public uint VideoProcessorCount;
        public uint MaxInputStreams;
        public uint MaxStreamStates;
    }
}
