// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(908,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WAVEFORMATEXTENSIBLE
    {
        public tWAVEFORMATEX Format;
        public __struct_ksmedia_3__union_0 Samples;
        public uint dwChannelMask;
        public Guid SubFormat;
    }
}
