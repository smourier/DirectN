// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ksopmapi.h(114,9)
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
