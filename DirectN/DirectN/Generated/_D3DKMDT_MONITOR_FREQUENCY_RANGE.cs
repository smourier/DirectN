// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_MONITOR_FREQUENCY_RANGE
    {
        public _D3DKMDT_MONITOR_CAPABILITIES_ORIGIN Origin;
        public _D3DKMDT_FREQUENCY_RANGE RangeLimits;
        public _D3DKMDT_MONITOR_FREQUENCY_RANGE_CONSTRAINT ConstraintType;
        public _D3DKMDT_MONITOR_FREQUENCY_RANGE__union_0 Constraint;
    }
}
