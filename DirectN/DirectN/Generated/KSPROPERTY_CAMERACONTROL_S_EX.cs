// generated from <Windows SDK Path>\shared\ksmedia.h
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
