// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_TVTUNER_CHANGE_INFO
    {
        public uint dwFlags;
        public uint dwCountryCode;
        public uint dwAnalogVideoStandard;
        public uint dwChannel;
    }
}
