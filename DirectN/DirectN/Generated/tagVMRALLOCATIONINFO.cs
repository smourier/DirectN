// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(19645,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVMRALLOCATIONINFO
    {
        public uint dwFlags;
        public IntPtr lpHdr;
        public IntPtr lpPixFmt;
        public tagSIZE szAspectRatio;
        public uint dwMinBuffers;
        public uint dwMaxBuffers;
        public uint dwInterlaceFlags;
        public tagSIZE szNativeSize;
    }
}
