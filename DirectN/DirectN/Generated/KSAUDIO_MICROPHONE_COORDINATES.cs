// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(1073,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_MICROPHONE_COORDINATES
    {
        public ushort usType;
        public short wXCoord;
        public short wYCoord;
        public short wZCoord;
        public short wVerticalAngle;
        public short wHorizontalAngle;
    }
}
