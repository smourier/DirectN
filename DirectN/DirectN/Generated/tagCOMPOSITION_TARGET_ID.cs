// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dcomptypes.h(116,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOMPOSITION_TARGET_ID
    {
        public LUID displayAdapterLuid;
        public LUID renderAdapterLuid;
        public uint vidPnSourceId;
        public uint vidPnTargetId;
        public uint uniqueId;
    }
}
