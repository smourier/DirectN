// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEOCONTROL_MODE_S
    {
        public KSIDENTIFIER Property;
        public uint StreamIndex;
        public int Mode;
    }
}
