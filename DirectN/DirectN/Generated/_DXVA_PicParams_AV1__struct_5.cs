// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1642,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_5
    {
        public _DXVA_PicParams_AV1__struct_5__union_0 __union_0;
        public _DXVA_PicParams_AV1__struct_5__union_1 __union_1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public IntPtr[] y_strengths;
        public _DXVA_PicParams_AV1__struct_5__union_2 __union_3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public IntPtr[] uv_strengths;
    }
}
