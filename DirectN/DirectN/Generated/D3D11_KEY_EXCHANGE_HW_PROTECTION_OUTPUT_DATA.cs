// generated from <Windows SDK Path>\um\d3d11_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA
    {
        public uint PrivateDataSize;
        public uint MaxHWProtectionDataSize;
        public uint HWProtectionDataSize;
        public ulong TransportTime;
        public ulong ExecutionTime;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] pbOutput;
    }
}
