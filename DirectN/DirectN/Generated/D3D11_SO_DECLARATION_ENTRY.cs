// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SO_DECLARATION_ENTRY
    {
        public uint Stream;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SemanticName;
        public uint SemanticIndex;
        public byte StartComponent;
        public byte ComponentCount;
        public byte OutputSlot;
    }
}
