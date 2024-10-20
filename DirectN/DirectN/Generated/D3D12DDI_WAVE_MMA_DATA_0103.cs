// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_WAVE_MMA_DATA_0103
    {
        public D3D12DDI_WAVE_MMA_INPUT_DATATYPE InputDataType;
        public D3D12DDI_WAVE_MMA_DIMENSION M;
        public D3D12DDI_WAVE_MMA_DIMENSION N;
        public bool Supported;
        public uint K;
        public D3D12DDI_WAVE_MMA_ACCUM_DATATYPE AccumDataTypes;
        public uint RequiredWaveLaneCountMin;
        public uint RequiredWaveLaneCountMax;
    }
}
