// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1704,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_7
    {
        public _DXVA_PicParams_AV1__struct_7__union_0 __union_0;
        public ushort grain_seed;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] scaling_points_y;
        public byte num_y_points;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] 
        public byte[] scaling_points_cb;
        public byte num_cb_points;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] 
        public byte[] scaling_points_cr;
        public byte num_cr_points;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)] 
        public byte[] ar_coeffs_y;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)] 
        public byte[] ar_coeffs_cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)] 
        public byte[] ar_coeffs_cr;
        public byte cb_mult;
        public byte cb_luma_mult;
        public byte cr_mult;
        public byte cr_luma_mult;
        public byte Reserved8Bits;
        public short cb_offset;
        public short cr_offset;
    }
}
