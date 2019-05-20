// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\amva.h(62,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _tag_AMVABeginFrameInfo
    {
        public uint dwDestSurfaceIndex;
        public IntPtr pInputData;
        public uint dwSizeInputData;
        public IntPtr pOutputData;
        public uint dwSizeOutputData;
    }
}
