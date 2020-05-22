// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmpdevices.h(48,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _WMP_WMDM_METADATA_ROUND_TRIP_PC2DEVICE
    {
        public uint dwChangesSinceTransactionID;
        public uint dwResultSetStartingIndex;
    }
}
