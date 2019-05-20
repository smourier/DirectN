// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(2890,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSNODEPROPERTY_AUDIO_CHANNEL
    {
        public KSNODEPROPERTY NodeProperty;
        public int Channel;
        public uint Reserved;
    }
}
