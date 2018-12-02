// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(511,9)
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
