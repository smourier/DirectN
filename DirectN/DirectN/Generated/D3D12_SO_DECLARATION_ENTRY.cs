// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(1310,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SO_DECLARATION_ENTRY
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
