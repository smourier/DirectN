// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ksopmapi.h(98,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_ENCRYPTED_INITIALIZATION_PARAMETERS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public byte[] abEncryptedInitializationParameters;
    }
}
