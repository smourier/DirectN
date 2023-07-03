// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3447,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_REFERENCE_DMA_BUFFER
    {
        public uint NbCall;
        public uint NbAllocationsReferenced;
        public uint MaxNbAllocationsReferenced;
        public uint NbNULLReference;
        public uint NbWriteReference;
        public uint NbRenamedAllocationsReferenced;
        public uint NbIterationSearchingRenamedAllocation;
        public uint NbLockedAllocationReferenced;
        public uint NbAllocationWithValidPrepatchingInfoReferenced;
        public uint NbAllocationWithInvalidPrepatchingInfoReferenced;
        public uint NbDMABufferSuccessfullyPrePatched;
        public uint NbPrimariesReferencesOverflow;
        public uint NbAllocationWithNonPreferredResources;
        public uint NbAllocationInsertedInMigrationTable;
    }
}
