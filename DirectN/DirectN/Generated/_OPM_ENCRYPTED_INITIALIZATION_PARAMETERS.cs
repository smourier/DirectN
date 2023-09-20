// generated from <Windows SDK Path>\um\ksopmapi.h
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
