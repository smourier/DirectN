// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
