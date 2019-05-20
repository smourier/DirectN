// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(284,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_EncryptProtocolHeader
    {
        public uint dwFunction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] ReservedBits;
        public Guid guidEncryptProtocol;
    }
}
