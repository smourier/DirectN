// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(1850,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_MIXLEVEL
    {
        public bool Mute;
        public int Level;
    }
}
