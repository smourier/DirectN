// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(219,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_PRIMARY_DESC
    {
        public uint Flags;
        public int VidPnSourceId;
        public DXGI_DDI_MODE_DESC ModeDesc;
        public uint DriverFlags;
    }
}
