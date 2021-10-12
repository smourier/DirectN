// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1493,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicEntry_AV1
    {
        public uint width;
        public uint height;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public int[] wmmat;
        public _DXVA_PicEntry_AV1__union_0 __union_3;
        public byte Index;
        public ushort Reserved16Bits;
    }
}
