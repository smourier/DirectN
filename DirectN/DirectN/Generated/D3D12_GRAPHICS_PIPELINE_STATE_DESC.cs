// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(1975,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_GRAPHICS_PIPELINE_STATE_DESC
    {
        public IntPtr pRootSignature;
        public D3D12_SHADER_BYTECODE VS;
        public D3D12_SHADER_BYTECODE PS;
        public D3D12_SHADER_BYTECODE DS;
        public D3D12_SHADER_BYTECODE HS;
        public D3D12_SHADER_BYTECODE GS;
        public D3D12_STREAM_OUTPUT_DESC StreamOutput;
        public D3D12_BLEND_DESC BlendState;
        public uint SampleMask;
        public D3D12_RASTERIZER_DESC RasterizerState;
        public D3D12_DEPTH_STENCIL_DESC DepthStencilState;
        public D3D12_INPUT_LAYOUT_DESC InputLayout;
        public D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue;
        public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;
        public uint NumRenderTargets;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public DXGI_FORMAT[] RTVFormats;
        public DXGI_FORMAT DSVFormat;
        public DXGI_SAMPLE_DESC SampleDesc;
        public uint NodeMask;
        public D3D12_CACHED_PIPELINE_STATE CachedPSO;
        public D3D12_PIPELINE_STATE_FLAGS Flags;
    }
}
