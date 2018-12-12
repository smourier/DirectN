// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1995,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ProcAmpControlCaps
    {
        public uint Size;
        public uint InputPool;
        public uint d3dOutputFormat;
        public uint ProcAmpControlProps;
        public uint VideoProcessingCaps;
    }
}
