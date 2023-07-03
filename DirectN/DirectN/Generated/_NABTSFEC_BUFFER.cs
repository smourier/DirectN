// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(4570,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _NABTSFEC_BUFFER
    {
        public uint dataSize;
        public ushort groupID;
        public ushort Reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 448)] 
        public byte[] data;
    }
}
