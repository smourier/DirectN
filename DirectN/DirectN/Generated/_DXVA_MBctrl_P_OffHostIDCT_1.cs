// generated from <Windows SDK Path>\um\dxva.h
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
        public _DXVA_MVvalue[] MVector;
    }
}
