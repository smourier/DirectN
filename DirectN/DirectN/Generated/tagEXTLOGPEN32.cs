// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(1416,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEXTLOGPEN32
    {
        public uint elpPenStyle;
        public uint elpWidth;
        public uint elpBrushStyle;
        public uint elpColor;
        public uint elpHatch;
        public uint elpNumEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] elpStyleEntry;
    }
}
