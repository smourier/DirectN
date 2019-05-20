// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(4562,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VBICODECFILTERING_SCANLINES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] DwordBitArray;
    }
}
