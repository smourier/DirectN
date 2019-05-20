// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2582,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_CAPS
    {
        public byte DSI2VersionMajor;
        public byte DSI2VersionMinor;
        public ushort TargetMaximumReturnPacketSize;
        public byte ResultCodeFlags;
        public byte ResultCodeStatus;
        public byte Revision;
        public byte Level;
        public byte DeviceClassHi;
        public byte DeviceClassLo;
        public byte ManufacturerHi;
        public byte ManufacturerLo;
        public byte ProductHi;
        public byte ProductLo;
        public byte LengthHi;
        public byte LengthLo;
    }
}
