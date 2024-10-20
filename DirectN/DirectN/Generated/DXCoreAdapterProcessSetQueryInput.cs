// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;
using uint32_t = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreAdapterProcessSetQueryInput
    {
        public uint arraySize;
        public IntPtr processIds;
    }
}
