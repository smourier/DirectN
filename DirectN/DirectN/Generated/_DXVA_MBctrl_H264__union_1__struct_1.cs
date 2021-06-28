// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(870,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_1__struct_1
    {
        public byte bSubMbShapes;
        public byte bSubMbPredModes;
        public ushort wMvBuffOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] bRefPicSelect;
    }
}
