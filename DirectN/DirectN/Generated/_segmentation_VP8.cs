// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _segmentation_VP8
    {
        public _segmentation_VP8__union_0 __union_0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public sbyte[] segment_feature_data;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] mb_segment_tree_probs;
    }
}
