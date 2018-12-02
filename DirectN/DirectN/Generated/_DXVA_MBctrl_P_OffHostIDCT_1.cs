// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(580,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_P_OffHostIDCT_1
    {
        public ushort wMBaddress;
        public ushort wMBtype;
        public uint dwMB_SNL;
        public ushort wPatternCode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public byte[] bNumCoef;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public _DXVA_MVvalue[][] MVector;
    }
}
