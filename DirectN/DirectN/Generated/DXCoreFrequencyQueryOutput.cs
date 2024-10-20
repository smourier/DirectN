// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreFrequencyQueryOutput
    {
        public ulong frequency;
        public ulong maxFrequency;
        public ulong maxOverclockedFrequency;
    }
}
