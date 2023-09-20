// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PHYSICAL_ADAPTER_INFORMATION
    {
        public _D3DKMT_ADAPTER_PERFDATA AdapterPerfData;
        public _D3DKMT_ADAPTER_PERFDATACAPS AdapterPerfDataCaps;
        public _D3DKMT_GPUVERSION GpuVersion;
    }
}
