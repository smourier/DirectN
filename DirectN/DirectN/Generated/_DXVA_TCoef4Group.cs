// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_TCoef4Group
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] TCoefIDX;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public short[] TCoefValue;
    }
}
