// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(15365,9)
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
