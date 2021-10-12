// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5209,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDEOPROTECTEDREGION
    {
        public uint PhysicalAdapterIndex;
        public uint SegmentIndex;
        public uint VprIndex;
        public IntPtr CurrentStartOffset;
        public IntPtr CurrentSize;
        public IntPtr NewStartOffset;
        public IntPtr NewSize;
    }
}
