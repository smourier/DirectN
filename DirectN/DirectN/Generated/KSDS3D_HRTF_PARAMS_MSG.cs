// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_HRTF_PARAMS_MSG
    {
        public uint Size;
        public uint Enabled;
        public bool SwapChannels;
        public bool ZeroAzimuth;
        public bool CrossFadeOutput;
        public uint FilterSize;
    }
}
