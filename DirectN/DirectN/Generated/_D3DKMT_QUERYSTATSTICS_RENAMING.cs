// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3465,9)
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
