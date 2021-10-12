// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2265,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DMABUFFERCAPS_DEPRECATED__struct_0
    {
        public uint Size;
        public uint PrivateDriverDataSize;
        public uint SegmentId;
        public uint Reserved1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] Reserved;
    }
}
