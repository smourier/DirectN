﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(996,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_BASE_ARGS
    {
        public IntPtr pDXGIBaseCallbacks;
        public DXGI_DDI_BASE_ARGS__union_0 __union_1;
    }
}