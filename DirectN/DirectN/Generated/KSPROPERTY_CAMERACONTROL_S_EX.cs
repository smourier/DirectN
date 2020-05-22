// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(5687,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_S_EX
    {
        public KSIDENTIFIER Property;
        public int Value;
        public uint Flags;
        public uint Capabilities;
        public tagRECT FocusRect;
    }
}
