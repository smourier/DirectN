// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(945,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDSOUND_BUFFERDESC
    {
        public uint Flags;
        public uint Control;
        public tWAVEFORMATEX WaveFormatEx;
    }
}
