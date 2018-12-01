// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(1948,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_D3D9INTERFACETIMINGS
    {
        public float WaitingForGPUToUseApplicationResourceTimePercent;
        public float WaitingForGPUToAcceptMoreCommandsTimePercent;
        public float WaitingForGPUToStayWithinLatencyTimePercent;
        public float WaitingForGPUExclusiveResourceTimePercent;
        public float WaitingForGPUOtherTimePercent;
    }
}
