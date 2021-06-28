// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dnthal.h(119,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTDeviceDesc_V3
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dcmColorModel;
        public uint dwDevCaps;
        public _D3DTRANSFORMCAPS dtcTransformCaps;
        public bool bClipping;
        public _D3DLIGHTINGCAPS dlcLightingCaps;
        public _D3DPrimCaps dpcLineCaps;
        public _D3DPrimCaps dpcTriCaps;
        public uint dwDeviceRenderBitDepth;
        public uint dwDeviceZBufferBitDepth;
        public uint dwMaxBufferSize;
        public uint dwMaxVertexCount;
        public uint dwMinTextureWidth;
        public uint dwMinTextureHeight;
        public uint dwMaxTextureWidth;
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
    }
}
