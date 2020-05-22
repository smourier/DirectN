// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(1814,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi)]
    public partial struct _D3DADAPTER_IDENTIFIER9
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
