// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAM_UVC_METADATATYPE_TIMESTAMP
    {
        public uint PresentationTimeStamp;
        public uint SourceClockReference;
        public __struct_ks_151__union_0 __union_2;
        public ushort Reserved0;
        public uint Reserved1;
    }
}
