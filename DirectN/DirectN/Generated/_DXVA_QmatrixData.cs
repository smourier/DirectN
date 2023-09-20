// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_QmatrixData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] bNewQmatrix;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] Qmatrix;
    }
}
