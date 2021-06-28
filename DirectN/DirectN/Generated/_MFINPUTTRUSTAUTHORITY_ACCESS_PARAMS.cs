// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(13157,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS
    {
        public uint dwSize;
        public uint dwVer;
        public uint cbSignatureOffset;
        public uint cbSignatureSize;
        public uint cbExtensionOffset;
        public uint cbExtensionSize;
        public uint cActions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MFINPUTTRUSTAUTHORITY_ACTION[] rgOutputActions;
    }
}
