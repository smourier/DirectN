// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_DESCRIPTION
    {
        public uint AccessFlags;
        public uint DescriptionSize;
        public KSIDENTIFIER PropTypeSet;
        public uint MembersListCount;
        public uint Reserved;
    }
}
