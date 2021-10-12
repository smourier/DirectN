// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(234,9)
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
