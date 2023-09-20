// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_PREPRATION
    {
        public uint BroadcastStall;
        public uint NbDMAPrepared;
        public uint NbDMAPreparedLongPath;
        public uint ImmediateHighestPreparationPass;
        public _D3DKMT_QUERYSTATISTICS_COUNTER AllocationsTrimmed;
    }
}
