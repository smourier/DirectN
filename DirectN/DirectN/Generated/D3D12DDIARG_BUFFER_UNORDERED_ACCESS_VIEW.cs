// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW
    {
        public D3D10DDI_HRESOURCE hDrvCounterResource;
        public ulong FirstElement;
        public uint NumElements;
        public uint StructureByteStride;
        public ulong CounterOffsetInBytes;
        public D3D12DDI_BUFFER_UAV_FLAGS Flags;
    }
}
