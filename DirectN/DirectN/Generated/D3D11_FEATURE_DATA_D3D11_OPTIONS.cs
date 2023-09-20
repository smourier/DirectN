// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
    {
        public bool OutputMergerLogicOp;
        public bool UAVOnlyRenderingForcedSampleCount;
        public bool DiscardAPIsSeenByDriver;
        public bool FlagsForUpdateAndCopySeenByDriver;
        public bool ClearView;
        public bool CopyWithOverlap;
        public bool ConstantBufferPartialUpdate;
        public bool ConstantBufferOffsetting;
        public bool MapNoOverwriteOnDynamicConstantBuffer;
        public bool MapNoOverwriteOnDynamicBufferSRV;
        public bool MultisampleRTVWithForcedSampleCountOne;
        public bool SAD4ShaderInstructions;
        public bool ExtendedDoublesShaderInstructions;
        public bool ExtendedResourceSharing;
    }
}
