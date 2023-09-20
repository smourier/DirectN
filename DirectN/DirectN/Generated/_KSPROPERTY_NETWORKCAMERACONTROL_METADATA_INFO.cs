// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSPROPERTY_NETWORKCAMERACONTROL_METADATA_INFO
    {
        public uint MetadataItems;
        public uint Size;
        public bool PTZStatus;
        public bool Events;
        public bool Analytics;
        public bool Reserved;
    }
}
