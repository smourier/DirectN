// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3340,9)
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
