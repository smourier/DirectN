// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(18649,9)
using System;
using System.Runtime.InteropServices;
using LPBITMAPINFOHEADER = DirectN.tagBITMAPINFOHEADER;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVMRALLOCATIONINFO
    {
        public uint dwFlags;
        public IntPtr lpHdr;
        public IntPtr lpPixFmt;
        public SIZE szAspectRatio;
        public uint dwMinBuffers;
        public uint dwMaxBuffers;
        public uint dwInterlaceFlags;
        public SIZE szNativeSize;
    }
}
