// generated from <Windows SDK Path>\um\d3dcaps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DPrimCaps
    {
        public uint dwSize;
        public uint dwMiscCaps;
        public uint dwRasterCaps;
        public uint dwZCmpCaps;
        public uint dwSrcBlendCaps;
        public uint dwDestBlendCaps;
        public uint dwAlphaCmpCaps;
        public uint dwShadeCaps;
        public uint dwTextureCaps;
        public uint dwTextureFilterCaps;
        public uint dwTextureBlendCaps;
        public uint dwTextureAddressCaps;
        public uint dwStippleWidth;
        public uint dwStippleHeight;
    }
}
