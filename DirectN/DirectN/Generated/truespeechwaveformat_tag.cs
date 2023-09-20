// generated from <Windows SDK Path>\shared\mmreg.h
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
