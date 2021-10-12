// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(188,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcBuffer
    {
        public IntPtr Ptr;
        public IntPtr Size;
        public uint Encoding;
    }
}
