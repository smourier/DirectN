// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEODECODER_STATUS_S
    {
        public KSIDENTIFIER Property;
        public uint NumberOfLines;
        public uint SignalLocked;
    }
}
