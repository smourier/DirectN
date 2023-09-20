// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_INPUT_ELEMENT_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SemanticName;
        public uint SemanticIndex;
        public DXGI_FORMAT Format;
        public uint InputSlot;
        public uint AlignedByteOffset;
        public D3D11_INPUT_CLASSIFICATION InputSlotClass;
        public uint InstanceDataStepRate;
    }
}
