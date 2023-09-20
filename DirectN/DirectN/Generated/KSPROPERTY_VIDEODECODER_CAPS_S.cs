// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEODECODER_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint StandardsSupported;
        public uint Capabilities;
        public uint SettlingTime;
        public uint HSyncPerVSync;
    }
}
