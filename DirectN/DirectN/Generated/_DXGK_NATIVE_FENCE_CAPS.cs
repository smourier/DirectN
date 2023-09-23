// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_NATIVE_FENCE_CAPS
    {
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegmentForCurrentValue;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegmentForMonitoredValue;
        public uint CurrentValueStride;
        public uint MonitoredValueStride;
        public byte MapToCmpAddressSpace;
    }
}
