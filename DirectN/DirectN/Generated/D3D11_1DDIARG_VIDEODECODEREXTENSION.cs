// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_VIDEODECODEREXTENSION
    {
        public uint Function;
        public IntPtr pPrivateInputData;
        public uint PrivateInputDataSize;
        public IntPtr pPrivateOutputData;
        public uint PrivateOutputDataSize;
        public uint ResourceCount;
        public IntPtr pResourceList;
    }
}
