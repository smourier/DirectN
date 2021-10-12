// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4878,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETUPPRIORITYBANDS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] gracePeriodForBand;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] processQuantumForBand;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] processGracePeriodForBand;
        public uint targetNormalBandPercentage;
    }
}
