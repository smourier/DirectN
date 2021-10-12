// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3130,9)
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
