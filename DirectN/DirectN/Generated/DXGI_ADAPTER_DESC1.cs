// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi.h(2376,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct DXGI_ADAPTER_DESC1
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string Description;
        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;
        public IntPtr DedicatedVideoMemory;
        public IntPtr DedicatedSystemMemory;
        public IntPtr SharedSystemMemory;
        public LUID AdapterLuid;
        public uint Flags;
    }
}
