// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_NATIVEFENCEMAPPING
    {
        public IntPtr CurrentValueCpuVa;
        public ulong CurrentValueGpuVa;
        public ulong MonitoredValueGpuVa;
    }
}
