// generated from <Windows SDK Path>\um\mfidl.h
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
