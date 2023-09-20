// generated from <Windows SDK Path>\um\dxva.h
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
