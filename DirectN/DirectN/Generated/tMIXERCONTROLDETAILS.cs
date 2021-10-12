// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(2304,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tMIXERCONTROLDETAILS
    {
        public uint cbStruct;
        public uint dwControlID;
        public uint cChannels;
        public tMIXERCONTROLDETAILS__union_0 __union_3;
        public uint cbDetails;
        public IntPtr paDetails;
    }
}
