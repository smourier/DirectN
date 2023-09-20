// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi)]
    public partial struct _D3DADAPTER_IDENTIFIER9_32
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string Driver;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string Description;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public long DriverVersion;
        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;
        public Guid DeviceIdentifier;
        public uint WHQLLevel;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _D3DADAPTER_IDENTIFIER9_64
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string Driver;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string Description;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public long DriverVersion;
        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;
        public Guid DeviceIdentifier;
        public uint WHQLLevel;
    }
}
