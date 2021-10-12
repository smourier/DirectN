// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddkmapi.h(403,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENVPCAPTUREDEVICEIN
    {
        public IntPtr hDirectDraw;
        public IntPtr hVideoPort;
        public uint dwStartLine;
        public uint dwEndLine;
        public uint dwCaptureEveryNFields;
        public IntPtr pfnCaptureClose;
        public IntPtr pContext;
        public uint dwFlags;
    }
}
