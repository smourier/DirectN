// generated from <Windows SDK Path>\um\ksopmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_GET_CODEC_INFO_PARAMETERS
    {
        public uint cbVerifier;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4052)] 
        public byte[] Verifier;
    }
}
