// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(278,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_D3DEXTENDEDCAPS
    {
        public uint dwSize;
        public uint dwMinTextureWidth;
        public uint dwMaxTextureWidth;
        public uint dwMinTextureHeight;
        public uint dwMaxTextureHeight;
        public uint dwMinStippleWidth;
        public uint dwMaxStippleWidth;
        public uint dwMinStippleHeight;
        public uint dwMaxStippleHeight;
        public uint dwMaxTextureRepeat;
        public uint dwMaxTextureAspectRatio;
        public uint dwMaxAnisotropy;
        public float dvGuardBandLeft;
        public float dvGuardBandTop;
        public float dvGuardBandRight;
        public float dvGuardBandBottom;
        public float dvExtentsAdjust;
        public uint dwStencilCaps;
        public uint dwFVFCaps;
        public uint dwTextureOpCaps;
        public ushort wMaxTextureBlendStages;
        public ushort wMaxSimultaneousTextures;
        public uint dwMaxActiveLights;
        public float dvMaxVertexW;
        public ushort wMaxUserClipPlanes;
        public ushort wMaxVertexBlendMatrices;
        public uint dwVertexProcessingCaps;
        public uint dwReserved1;
        public uint dwReserved2;
        public uint dwReserved3;
        public uint dwReserved4;
    }
}
