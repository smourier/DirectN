// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_SHADER_VARIABLE_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public uint StartOffset;
        public uint Size;
        public uint uFlags;
        public IntPtr DefaultValue;
        public uint StartTexture;
        public uint TextureSize;
        public uint StartSampler;
        public uint SamplerSize;
    }
}
