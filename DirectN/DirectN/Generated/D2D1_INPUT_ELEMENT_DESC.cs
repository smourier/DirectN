// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(291,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This defines a single element of the vertex layout.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_INPUT_ELEMENT_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string semanticName;
        public uint semanticIndex;
        public DXGI_FORMAT format;
        public uint inputSlot;
        public uint alignedByteOffset;
    }
}
