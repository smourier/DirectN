// generated from <Windows SDK Path>\um\dxva.h
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
