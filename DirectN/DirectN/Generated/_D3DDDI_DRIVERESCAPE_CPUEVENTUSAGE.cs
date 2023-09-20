// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_DRIVERESCAPE_CPUEVENTUSAGE
    {
        public _D3DDDI_DRIVERESCAPETYPE EscapeType;
        public uint hSyncObject;
        public ulong hKmdCpuEvent;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] Usage;
    }
}
