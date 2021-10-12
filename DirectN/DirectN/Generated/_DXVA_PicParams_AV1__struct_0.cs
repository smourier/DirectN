// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1528,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_0
    {
        public byte cols;
        public byte rows;
        public ushort context_update_id;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public ushort[] widths;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public ushort[] heights;
    }
}
