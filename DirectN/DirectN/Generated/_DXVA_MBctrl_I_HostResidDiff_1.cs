// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(550,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_I_HostResidDiff_1
    {
        public ushort wMBaddress;
        public ushort wMBtype;
        public uint dwMB_SNL;
        public ushort wPatternCode;
        public ushort wPC_Overflow;
        public uint dwReservedBits2;
    }
}
