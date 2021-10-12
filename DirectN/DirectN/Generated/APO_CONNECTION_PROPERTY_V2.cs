// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioapotypes.h(89,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_CONNECTION_PROPERTY_V2
    {
        public APO_CONNECTION_PROPERTY property;
        public ulong u64QPCTime;
    }
}
