// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WMDRM_IMPORT_INIT_STRUCT
    {
        public uint dwVersion;
        public uint cbEncryptedSessionKeyMessage;
        public IntPtr pbEncryptedSessionKeyMessage;
        public uint cbEncryptedKeyMessage;
        public IntPtr pbEncryptedKeyMessage;
    }
}
