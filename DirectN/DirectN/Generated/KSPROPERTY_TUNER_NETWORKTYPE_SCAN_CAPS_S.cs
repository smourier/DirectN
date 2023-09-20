// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_NETWORKTYPE_SCAN_CAPS_S
    {
        public KSIDENTIFIER Property;
        public Guid NetworkType;
        public uint BufferSize;
        public IntPtr NetworkTunerCapabilities;
    }
}
