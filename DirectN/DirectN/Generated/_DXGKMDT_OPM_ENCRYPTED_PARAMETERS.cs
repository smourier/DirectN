// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
