// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_PREEMPTION_CAPS
    {
        public _D3DKMDT_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
        public _D3DKMDT_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
    }
}
