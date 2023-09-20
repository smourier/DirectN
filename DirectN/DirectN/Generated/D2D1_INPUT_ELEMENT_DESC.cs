// generated from <Windows SDK Path>\um\d2d1effectauthor.h
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
