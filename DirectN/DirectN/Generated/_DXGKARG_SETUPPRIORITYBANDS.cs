// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
