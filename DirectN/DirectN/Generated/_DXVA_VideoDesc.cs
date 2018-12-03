// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(420,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_VideoDesc
    {
        public uint Size;
        public uint SampleWidth;
        public uint SampleHeight;
        public uint SampleFormat;
        public int d3dFormat;
        public _DXVA_Frequency InputSampleFreq;
        public _DXVA_Frequency OutputFrameFreq;
    }
}
