// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dcaps.h(395,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDeviceDesc7
    {
        public uint dwDevCaps;
        public _D3DPrimCaps dpcLineCaps;
        public _D3DPrimCaps dpcTriCaps;
        public uint dwDeviceRenderBitDepth;
        public uint dwDeviceZBufferBitDepth;
        public uint dwMinTextureWidth;
        public uint dwMinTextureHeight;
        public uint dwMaxTextureWidth;
        public uint dwMaxTextureHeight;
        public uint dwMaxTextureRepeat;
        public uint dwMaxTextureAspectRatio;
        public uint dwMaxAnisotropy;
        public int dvGuardBandLeft;
        public int dvGuardBandTop;
        public int dvGuardBandRight;
        public int dvGuardBandBottom;
        public int dvExtentsAdjust;
        public uint dwStencilCaps;
        public uint dwFVFCaps;
        public uint dwTextureOpCaps;
        public ushort wMaxTextureBlendStages;
        public ushort wMaxSimultaneousTextures;
        public uint dwMaxActiveLights;
        public int dvMaxVertexW;
        public Guid deviceGUID;
        public ushort wMaxUserClipPlanes;
        public ushort wMaxVertexBlendMatrices;
        public uint dwVertexProcessingCaps;
        public uint dwReserved1;
        public uint dwReserved2;
        public uint dwReserved3;
        public uint dwReserved4;
    }
}
