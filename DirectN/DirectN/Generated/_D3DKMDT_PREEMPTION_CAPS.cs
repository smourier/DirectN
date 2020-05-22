// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1300,9)
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
