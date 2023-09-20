// generated from <Windows SDK Path>\shared\mmreg.h
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
