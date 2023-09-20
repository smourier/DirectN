// generated from <Windows SDK Path>\um\ddkmapi.h
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
