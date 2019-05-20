// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(5036,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_FRAME_INFO
    {
        public uint ExtendedHeaderSize;
        public uint dwFrameFlags;
        public long PictureNumber;
        public long DropCount;
        public IntPtr hDirectDraw;
        public IntPtr hSurfaceHandle;
        public tagRECT DirectDrawRect;
        public tagKS_FRAME_INFO__union_0 __union_7;
        public uint Reserved2;
        public tagKS_FRAME_INFO__union_1 __union_9;
    }
}
