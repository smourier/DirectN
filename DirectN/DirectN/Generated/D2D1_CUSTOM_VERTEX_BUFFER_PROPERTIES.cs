// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This defines the input layout of vertices and the vertex shader which processes them.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES
    {
        public IntPtr shaderBufferWithInputSignature;
        public uint shaderBufferSize;
        public IntPtr inputElements;
        public uint elementCount;
        public uint stride;
    }
}
