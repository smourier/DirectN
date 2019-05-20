// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3075,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONUSAGEINFO1
    {
        public _DXGK_ALLOCATIONUSAGEINFO1__union_0 Flags;
        public _DXGK_ALLOCATIONUSAGEINFO1__union_1 __union_1;
        public uint SwizzledFormat;
        public uint ByteOffset;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public uint Depth;
        public uint SlicePitch;
    }
}
