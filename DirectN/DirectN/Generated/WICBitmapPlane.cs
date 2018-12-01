// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(1057,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICBitmapPlane
    {
        public Guid Format;
        public IntPtr pbBuffer;
        public uint cbStride;
        public uint cbBufferSize;
    }
}
