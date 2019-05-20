// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1187,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DECODEEXTENSIONEXECUTE
    {
        public IntPtr hDecode;
        public uint Function;
        public IntPtr pPrivateInput;
        public IntPtr pPrivateOutput;
        public uint NumBuffers;
        public IntPtr pBuffers;
    }
}
