// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Hash digest type for ShaderHash.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcShaderHash
    {
        /// <summary>
        /// DXC_HASHFLAG_*
        /// </summary>
        public uint Flags;
        /// <summary>
        /// The hash digest
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] HashDigest;
    }
}
