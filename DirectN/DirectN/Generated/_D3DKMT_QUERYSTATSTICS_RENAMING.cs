// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_RENAMING
    {
        public uint NbAllocationsRenamed;
        public uint NbAllocationsShrinked;
        public uint NbRenamedBuffer;
        public uint MaxRenamingListLength;
        public uint NbFailuresDueToRenamingLimit;
        public uint NbFailuresDueToCreateAllocation;
        public uint NbFailuresDueToOpenAllocation;
        public uint NbFailuresDueToLowResource;
        public uint NbFailuresDueToNonRetiredLimit;
    }
}
