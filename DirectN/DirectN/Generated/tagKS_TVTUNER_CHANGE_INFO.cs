// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(4055,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_TVTUNER_CHANGE_INFO
    {
        public uint dwFlags;
        public uint dwCountryCode;
        public uint dwAnalogVideoStandard;
        public uint dwChannel;
    }
}
