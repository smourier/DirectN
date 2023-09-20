// generated from <Windows SDK Path>\shared\ksmedia.h
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
