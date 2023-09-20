// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOVERLAYFX
    {
        public uint dwSize;
        public uint dwAlphaEdgeBlendBitDepth;
        public uint dwAlphaEdgeBlend;
        public uint dwReserved;
        public uint dwAlphaDestConstBitDepth;
        public _DDOVERLAYFX__union_0 __union_5;
        public uint dwAlphaSrcConstBitDepth;
        public _DDOVERLAYFX__union_1 __union_7;
        public _DDCOLORKEY dckDestColorkey;
        public _DDCOLORKEY dckSrcColorkey;
        public uint dwDDFX;
        public uint dwFlags;
    }
}
