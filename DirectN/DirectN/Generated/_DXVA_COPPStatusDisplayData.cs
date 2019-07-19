// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(2261,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusDisplayData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint DisplayWidth;
        public uint DisplayHeight;
        public uint Format;
        public uint d3dFormat;
        public uint FreqNumerator;
        public uint FreqDenominator;
    }
}
