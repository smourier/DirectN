// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_0020
    {
        public D3D10DDI_HRESOURCE hDrvInputTexture;
        public uint Subresource;
        public D3D12DDI_VIDEO_PROCESS_REFERENCES_INFO_0020 ReferenceInfo;
    }
}
