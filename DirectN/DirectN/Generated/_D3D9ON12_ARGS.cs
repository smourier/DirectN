// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d9on12.h(27,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D9ON12_ARGS
    {
        public bool Enable9On12;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pD3D12Device;
        public object[] ppD3D12Queues;
        public uint NumQueues;
        public uint NodeMask;
    }
}
