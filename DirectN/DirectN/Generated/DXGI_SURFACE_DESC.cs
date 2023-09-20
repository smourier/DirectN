// generated from <Windows SDK Path>\shared\dxgi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_SURFACE_DESC
    {
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
    }
}
