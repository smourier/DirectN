// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(2933,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSNODEPROPERTY_AUDIO_PROPERTY
    {
        public KSNODEPROPERTY NodeProperty;
        public IntPtr AppContext;
        public uint Length;
    }
}
