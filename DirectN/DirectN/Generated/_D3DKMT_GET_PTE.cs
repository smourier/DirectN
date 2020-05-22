// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2469,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GET_PTE
    {
        public uint PhysicalAdapterIndex;
        public uint PageTableLevel;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public uint[] PageTableIndex;
        public byte b64KBPte;
        public uint NumPtes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public _DXGK_PTE[] Pte;
        public uint NumValidEntries;
    }
}
