// generated from <Windows SDK Path>\um\dxva2api.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_DecodeExtensionData
    {
        public uint Function;
        public IntPtr pPrivateInputData;
        public uint PrivateInputDataSize;
        public IntPtr pPrivateOutputData;
        public uint PrivateOutputDataSize;
    }
}
