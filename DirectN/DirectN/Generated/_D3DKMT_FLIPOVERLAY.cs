// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPOVERLAY
    {
        public uint hDevice;
        public uint hOverlay;
        public uint hSource;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
