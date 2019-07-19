// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ks.h(2084,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAM_UVC_METADATATYPE_TIMESTAMP
    {
        public uint PresentationTimeStamp;
        public uint SourceClockReference;
        public __struct_ks_426__union_0 __union_2;
        public ushort Reserved0;
        public uint Reserved1;
    }
}
