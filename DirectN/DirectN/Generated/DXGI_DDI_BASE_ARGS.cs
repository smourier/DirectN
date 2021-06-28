// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(1012,9)
using System;
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
