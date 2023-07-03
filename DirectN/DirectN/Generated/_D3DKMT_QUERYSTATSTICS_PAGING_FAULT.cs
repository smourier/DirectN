// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3487,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_PAGING_FAULT
    {
        public _D3DKMT_QUERYSTATISTICS_COUNTER Faults;
        public _D3DKMT_QUERYSTATISTICS_COUNTER FaultsFirstTimeAccess;
        public _D3DKMT_QUERYSTATISTICS_COUNTER FaultsReclaimed;
        public _D3DKMT_QUERYSTATISTICS_COUNTER FaultsMigration;
        public _D3DKMT_QUERYSTATISTICS_COUNTER FaultsIncorrectResource;
        public _D3DKMT_QUERYSTATISTICS_COUNTER FaultsLostContent;
        public _D3DKMT_QUERYSTATISTICS_COUNTER FaultsEvicted;
        public _D3DKMT_QUERYSTATISTICS_COUNTER AllocationsMEM_RESET;
        public _D3DKMT_QUERYSTATISTICS_COUNTER AllocationsUnresetSuccess;
        public _D3DKMT_QUERYSTATISTICS_COUNTER AllocationsUnresetFail;
        public uint AllocationsUnresetSuccessRead;
        public uint AllocationsUnresetFailRead;
        public _D3DKMT_QUERYSTATISTICS_COUNTER Evictions;
        public _D3DKMT_QUERYSTATISTICS_COUNTER EvictionsDueToPreparation;
        public _D3DKMT_QUERYSTATISTICS_COUNTER EvictionsDueToLock;
        public _D3DKMT_QUERYSTATISTICS_COUNTER EvictionsDueToClose;
        public _D3DKMT_QUERYSTATISTICS_COUNTER EvictionsDueToPurge;
        public _D3DKMT_QUERYSTATISTICS_COUNTER EvictionsDueToSuspendCPUAccess;
    }
}
