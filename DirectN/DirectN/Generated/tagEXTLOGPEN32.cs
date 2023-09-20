// generated from <Windows SDK Path>\um\wingdi.h
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
