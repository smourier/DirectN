// generated from <Windows SDK Path>\um\dxva2trace.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_dxva2trace_7
    {
        public int wmiHeader;
        public ulong pObject;
        public ulong pRenderTarget;
        public ulong TargetFrameTime;
        public tagRECT TargetRect;
        public bool Enter;
    }
}
