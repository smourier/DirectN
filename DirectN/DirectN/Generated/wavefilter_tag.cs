// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\mmreg.h(3449,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wavefilter_tag
    {
        public uint cbStruct;
        public uint dwFilterTag;
        public uint fdwFilter;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public uint[] dwReserved;
    }
}
