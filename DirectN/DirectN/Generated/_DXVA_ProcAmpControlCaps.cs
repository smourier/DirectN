// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva9typ.h(660,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ProcAmpControlCaps
    {
        public uint Size;
        public uint InputPool;
        public int d3dOutputFormat;
        public uint ProcAmpControlProps;
        public uint VideoProcessingCaps;
    }
}
