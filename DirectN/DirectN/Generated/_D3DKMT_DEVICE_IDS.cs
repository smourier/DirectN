// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1793,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DEVICE_IDS
    {
        public uint VendorID;
        public uint DeviceID;
        public uint SubVendorID;
        public uint SubSystemID;
        public uint RevisionID;
        public uint BusType;
    }
}
