// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(435,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DIRTYREGIONS
    {
        public uint NumRects;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public tagRECT[] Rects;
    }
}
