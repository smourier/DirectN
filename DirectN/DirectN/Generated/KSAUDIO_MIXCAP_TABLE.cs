// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_MIXCAP_TABLE
    {
        public uint InputChannels;
        public uint OutputChannels;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public KSAUDIO_MIX_CAPS[] Capabilities;
    }
}
