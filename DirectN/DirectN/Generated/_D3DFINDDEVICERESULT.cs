// generated from <Windows SDK Path>\um\d3dcaps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DFINDDEVICERESULT
    {
        public uint dwSize;
        public Guid guid;
        public _D3DDeviceDesc ddHwDesc;
        public _D3DDeviceDesc ddSwDesc;
    }
}
