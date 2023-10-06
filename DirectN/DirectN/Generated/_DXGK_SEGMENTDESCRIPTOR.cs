// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR
    {
        public long BaseAddress;
        public long CpuTranslatedAddress;
        public IntPtr Size;
        public uint NbOfBanks;
        public IntPtr pBankRangeTable;
        public IntPtr CommitLimit;
        public _DXGK_SEGMENTFLAGS Flags;
    }
}
