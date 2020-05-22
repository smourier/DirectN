// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(8211,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _KSAUDIOMODULE_DESCRIPTOR
    {
        public Guid ClassId;
        public uint InstanceId;
        public uint VersionMajor;
        public uint VersionMinor;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string Name;
    }
}
