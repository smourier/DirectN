// generated from <Windows SDK Path>\um\d3d9on12.h
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
