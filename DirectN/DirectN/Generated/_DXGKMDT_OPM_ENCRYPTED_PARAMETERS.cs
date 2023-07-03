// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmdt.h(1685,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_ENCRYPTED_PARAMETERS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public byte[] abEncryptedParameters;
    }
}
