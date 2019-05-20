// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(2056,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEDEFERREDCONTEXT
    {
        public D3D11DDIARG_CREATEDEFERREDCONTEXT__union_0 __union_0;
        public D3D10DDI_HDEVICE hDrvContext;
        public D3D10DDI_HRTCORELAYER hRTCoreLayer;
        public D3D11DDIARG_CREATEDEFERREDCONTEXT__union_1 __union_3;
        public uint Flags;
    }
}
