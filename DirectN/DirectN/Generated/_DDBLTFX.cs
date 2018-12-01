// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(275,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDBLTFX
    {
        public uint dwSize;
        public uint dwDDFX;
        public uint dwROP;
        public uint dwDDROP;
        public uint dwRotationAngle;
        public uint dwZBufferOpCode;
        public uint dwZBufferLow;
        public uint dwZBufferHigh;
        public uint dwZBufferBaseDest;
        public uint dwZDestConstBitDepth;
        public _DDBLTFX__union_0 __union_10;
        public uint dwZSrcConstBitDepth;
        public _DDBLTFX__union_1 __union_12;
        public uint dwAlphaEdgeBlendBitDepth;
        public uint dwAlphaEdgeBlend;
        public uint dwReserved;
        public uint dwAlphaDestConstBitDepth;
        public _DDBLTFX__union_2 __union_17;
        public uint dwAlphaSrcConstBitDepth;
        public _DDBLTFX__union_3 __union_19;
        public _DDBLTFX__union_4 __union_20;
        public _DDCOLORKEY ddckDestColorkey;
        public _DDCOLORKEY ddckSrcColorkey;
    }
}
