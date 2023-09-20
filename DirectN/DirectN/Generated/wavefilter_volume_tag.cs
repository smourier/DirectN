// generated from <Windows SDK Path>\shared\mmreg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wavefilter_volume_tag
    {
        public wavefilter_tag wfltr;
        public uint dwVolume;
    }
}
