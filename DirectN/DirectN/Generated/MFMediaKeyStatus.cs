// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(17627,9)
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
