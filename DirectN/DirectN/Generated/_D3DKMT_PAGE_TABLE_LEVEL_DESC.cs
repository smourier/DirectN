// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2438,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PAGE_TABLE_LEVEL_DESC
    {
        public uint IndexBitCount;
        public ulong IndexMask;
        public ulong IndexShift;
        public ulong LowerLevelsMask;
        public ulong EntryCoverageInPages;
    }
}
