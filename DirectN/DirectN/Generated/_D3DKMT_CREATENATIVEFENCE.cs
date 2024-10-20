// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATENATIVEFENCE
    {
        public uint hDevice;
        public uint hSyncObject;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] PrivateDriverData;
        public _D3DDDI_NATIVEFENCEINFO Info;
        public _D3DKMT_CREATENATIVEFENCE_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] Reserved;
    }
}
