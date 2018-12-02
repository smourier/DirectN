// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(2814,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct truespeechwaveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort wRevision;
        public ushort nSamplesPerBlock;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] abReserved;
    }
}
