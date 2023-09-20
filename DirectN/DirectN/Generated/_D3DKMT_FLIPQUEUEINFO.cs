// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPQUEUEINFO
    {
        public uint MaxHardwareFlipQueueLength;
        public uint MaxSoftwareFlipQueueLength;
        public _D3DKMT_FLIPINFOFLAGS FlipFlags;
    }
}
