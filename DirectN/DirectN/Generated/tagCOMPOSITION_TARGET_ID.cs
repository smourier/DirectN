// generated from <Windows SDK Path>\shared\dcomptypes.h
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
