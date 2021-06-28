// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1325,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _segmentation_VP9
    {
        public _segmentation_VP9__union_0 __union_0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public byte[] tree_probs;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] pred_probs;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public short[] feature_data;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] feature_mask;
    }
}
