// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFMediaKeyStatus
    {
        public IntPtr pbKeyId;
        public uint cbKeyId;
        public MF_MEDIAKEY_STATUS eMediaKeyStatus;
    }
}
