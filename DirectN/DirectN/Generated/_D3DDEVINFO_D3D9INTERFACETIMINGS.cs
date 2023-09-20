// generated from <Windows SDK Path>\shared\d3d9types.h
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
