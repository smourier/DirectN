// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(771,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_MONITOR_SOURCE_MODE
    {
        public uint Id;
        public _D3DKMDT_VIDEO_SIGNAL_INFO VideoSignalInfo;
        public _D3DKMDT_COLOR_BASIS ColorBasis;
        public _D3DKMDT_COLOR_COEFF_DYNAMIC_RANGES ColorCoeffDynamicRanges;
        public _D3DKMDT_MONITOR_CAPABILITIES_ORIGIN Origin;
        public _D3DKMDT_MODE_PREFERENCE Preference;
    }
}
