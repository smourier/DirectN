// generated from <Windows SDK Path>\um\strmif.h
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
