// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_SET_PROTECTION_LEVEL_PARAMETERS
    {
        public uint ulProtectionType;
        public uint ulProtectionLevel;
        public uint Reserved;
        public uint Reserved2;
    }
}
