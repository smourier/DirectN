// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2trace.h(135,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_dxva2trace_7
    {
        public int wmiHeader;
        public ulong pObject;
        public ulong pRenderTarget;
        public ulong TargetFrameTime;
        public RECT TargetRect;
        public bool Enter;
    }
}
