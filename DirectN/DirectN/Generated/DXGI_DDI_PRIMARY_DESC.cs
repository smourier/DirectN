// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_PRIMARY_DESC
    {
        public uint Flags;
        public uint VidPnSourceId;
        public DXGI_DDI_MODE_DESC ModeDesc;
        public uint DriverFlags;
    }
}
