// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(5494,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSEVENT_TUNER_INITIATE_SCAN_S
    {
        public KSEVENTDATA EventData;
        public uint StartFrequency;
        public uint EndFrequency;
    }
}
