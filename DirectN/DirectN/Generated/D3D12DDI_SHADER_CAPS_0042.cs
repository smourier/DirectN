// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(6661,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SHADER_CAPS_0042
    {
        public D3D12DDI_SHADER_MIN_PRECISION MinPrecision;
        public bool DoubleOps;
        public bool ShaderSpecifiedStencilRef;
        public bool TypedUAVLoadAdditionalFormats;
        public bool ROVs;
        public bool WaveOps;
        public uint WaveLaneCountMin;
        public uint WaveLaneCountMax;
        public uint TotalLaneCount;
        public bool Int64Ops;
        public bool Native16BitOps;
    }
}
