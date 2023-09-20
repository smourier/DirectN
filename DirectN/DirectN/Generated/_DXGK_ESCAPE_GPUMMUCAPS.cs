// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ESCAPE_GPUMMUCAPS
    {
        public byte ReadOnlyMemorySupported;
        public byte NoExecuteMemorySupported;
        public byte ZeroInPteSupported;
        public byte CacheCoherentMemorySupported;
        public byte LargePageSupported;
        public byte DualPteSupported;
        public byte AllowNonAlignedLargePageAddress;
        public uint VirtualAddressBitCount;
        public uint PageTableLevelCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public _D3DKMT_PAGE_TABLE_LEVEL_DESC[] PageTableLevelDesk;
    }
}
