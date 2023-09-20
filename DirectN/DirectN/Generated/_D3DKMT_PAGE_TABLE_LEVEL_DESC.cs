// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
