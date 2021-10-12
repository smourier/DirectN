// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1593,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public partial struct _DXVA_PicParams_AV1__struct_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] filter_level;
        public byte filter_level_u;
        public byte filter_level_v;
        public byte sharpness_level;
        public _DXVA_PicParams_AV1__struct_3__union_0 __union_4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)] 
        public string ref_deltas;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)] 
        public string mode_deltas;
        public byte delta_lf_res;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] frame_restoration_type;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public ushort[] log2_restoration_unit_size;
        public ushort Reserved16Bits;
    }
}
