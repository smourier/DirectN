// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PREEMPTION_INFORMATION
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] PreemptionCounter;
    }
}
