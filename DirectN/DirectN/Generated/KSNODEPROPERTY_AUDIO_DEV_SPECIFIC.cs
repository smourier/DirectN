// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSNODEPROPERTY_AUDIO_DEV_SPECIFIC
    {
        public KSNODEPROPERTY NodeProperty;
        public uint DevSpecificId;
        public uint DeviceInfo;
        public uint Length;
    }
}
