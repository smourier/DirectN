// generated from <Windows SDK Path>\shared\d3d9caps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DCAPS9
    {
        public int DeviceType;
        public uint AdapterOrdinal;
        public uint Caps;
        public uint Caps2;
        public uint Caps3;
        public uint PresentationIntervals;
        public uint CursorCaps;
        public uint DevCaps;
        public uint PrimitiveMiscCaps;
        public uint RasterCaps;
        public uint ZCmpCaps;
        public uint SrcBlendCaps;
        public uint DestBlendCaps;
        public uint AlphaCmpCaps;
        public uint ShadeCaps;
        public uint TextureCaps;
        public uint TextureFilterCaps;
        public uint CubeTextureFilterCaps;
        public uint VolumeTextureFilterCaps;
        public uint TextureAddressCaps;
        public uint VolumeTextureAddressCaps;
        public uint LineCaps;
        public uint MaxTextureWidth;
        public uint MaxTextureHeight;
        public uint MaxVolumeExtent;
        public uint MaxTextureRepeat;
        public uint MaxTextureAspectRatio;
        public uint MaxAnisotropy;
        public float MaxVertexW;
        public float GuardBandLeft;
        public float GuardBandTop;
        public float GuardBandRight;
        public float GuardBandBottom;
        public float ExtentsAdjust;
        public uint StencilCaps;
        public uint FVFCaps;
        public uint TextureOpCaps;
        public uint MaxTextureBlendStages;
        public uint MaxSimultaneousTextures;
        public uint VertexProcessingCaps;
        public uint MaxActiveLights;
        public uint MaxUserClipPlanes;
        public uint MaxVertexBlendMatrices;
        public uint MaxVertexBlendMatrixIndex;
        public float MaxPointSize;
        public uint MaxPrimitiveCount;
        public uint MaxVertexIndex;
        public uint MaxStreams;
        public uint MaxStreamStride;
        public uint VertexShaderVersion;
        public uint MaxVertexShaderConst;
        public uint PixelShaderVersion;
        public float PixelShader1xMaxValue;
        public uint DevCaps2;
        public float MaxNpatchTessellationLevel;
        public uint Reserved5;
        public uint MasterAdapterOrdinal;
        public uint AdapterOrdinalInGroup;
        public uint NumberOfAdaptersInGroup;
        public uint DeclTypes;
        public uint NumSimultaneousRTs;
        public uint StretchRectFilterCaps;
        public _D3DVSHADERCAPS2_0 VS20Caps;
        public _D3DPSHADERCAPS2_0 PS20Caps;
        public uint VertexTextureFilterCaps;
        public uint MaxVShaderInstructionsExecuted;
        public uint MaxPShaderInstructionsExecuted;
        public uint MaxVertexShader30InstructionSlots;
        public uint MaxPixelShader30InstructionSlots;
    }
}
