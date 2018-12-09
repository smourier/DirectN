// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1820,9)
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
