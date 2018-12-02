// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(2604,9)
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
