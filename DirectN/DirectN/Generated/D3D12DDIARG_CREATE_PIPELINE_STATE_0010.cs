// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_PIPELINE_STATE_0010
    {
        public D3D10DDI_HSHADER hComputeShader;
        public D3D10DDI_HSHADER hVertexShader;
        public D3D10DDI_HSHADER hPixelShader;
        public D3D10DDI_HSHADER hDomainShader;
        public D3D10DDI_HSHADER hHullShader;
        public D3D10DDI_HSHADER hGeometryShader;
        public D3D12DDI_HROOTSIGNATURE hRootSignature;
        public D3D10DDI_HBLENDSTATE hBlendState;
        public uint SampleMask;
        public D3D10DDI_HRASTERIZERSTATE hRasterizerState;
        public D3D10DDI_HDEPTHSTENCILSTATE hDepthStencilState;
        public D3D10DDI_HELEMENTLAYOUT hElementLayout;
        public D3D12DDI_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue;
        public D3D12DDI_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;
        public uint NumRenderTargets;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public DXGI_FORMAT[] RTVFormats;
        public DXGI_FORMAT DSVFormat;
        public DXGI_SAMPLE_DESC SampleDesc;
        public uint NodeMask;
        public D3D12DDI_LIBRARY_REFERENCE_0010 LibraryReference;
    }
}
