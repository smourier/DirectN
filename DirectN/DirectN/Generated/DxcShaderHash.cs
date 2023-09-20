// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcShaderHash
    {
        public uint Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] HashDigest;
    }
}
