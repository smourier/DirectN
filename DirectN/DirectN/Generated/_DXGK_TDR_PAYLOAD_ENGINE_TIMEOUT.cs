// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_TDR_PAYLOAD_ENGINE_TIMEOUT
    {
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public ulong LastHwCompletedFenceId;
        public ulong LastHwSubmittedFenceId;
        public uint NumberOfPendingSuspendRequests;
        public uint NumberOfReadyInteractiveHwQueues;
        public IntPtr hContext;
    }
}
