// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(1980,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT
    {
        public IntPtr pShaderCode;
        public IntPtr pOutputStreamDecl;
        public uint NumEntries;
        public IntPtr BufferStridesInBytes;
        public uint NumStrides;
        public uint RasterizedStream;
    }
}
