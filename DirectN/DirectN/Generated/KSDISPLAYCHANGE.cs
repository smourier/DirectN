// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct KSDISPLAYCHANGE
    {
        public uint PelsWidth;
        public uint PelsHeight;
        public uint BitsPerPel;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string DeviceID;
    }
}
