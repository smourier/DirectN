// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DPRESENT_PARAMETERS_32
    {
        public uint BackBufferWidth;
        public uint BackBufferHeight;
        public _D3DFORMAT BackBufferFormat;
        public uint BackBufferCount;
        public _D3DMULTISAMPLE_TYPE MultiSampleType;
        public uint MultiSampleQuality;
        public _D3DSWAPEFFECT SwapEffect;
        public IntPtr hDeviceWindow;
        public bool Windowed;
        public bool EnableAutoDepthStencil;
        public _D3DFORMAT AutoDepthStencilFormat;
        public uint Flags;
        public uint FullScreen_RefreshRateInHz;
        public uint PresentationInterval;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DPRESENT_PARAMETERS_64
    {
        public uint BackBufferWidth;
        public uint BackBufferHeight;
        public _D3DFORMAT BackBufferFormat;
        public uint BackBufferCount;
        public _D3DMULTISAMPLE_TYPE MultiSampleType;
        public uint MultiSampleQuality;
        public _D3DSWAPEFFECT SwapEffect;
        public IntPtr hDeviceWindow;
        public bool Windowed;
        public bool EnableAutoDepthStencil;
        public _D3DFORMAT AutoDepthStencilFormat;
        public uint Flags;
        public uint FullScreen_RefreshRateInHz;
        public uint PresentationInterval;
    }
}
