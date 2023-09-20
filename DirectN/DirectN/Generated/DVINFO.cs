// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DVINFO
    {
        public uint dwDVAAuxSrc;
        public uint dwDVAAuxCtl;
        public uint dwDVAAuxSrc1;
        public uint dwDVAAuxCtl1;
        public uint dwDVVAuxSrc;
        public uint dwDVVAuxCtl;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] dwDVReserved;
    }
}
