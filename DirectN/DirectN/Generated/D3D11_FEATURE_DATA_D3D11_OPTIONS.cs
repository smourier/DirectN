// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(7343,9)
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
