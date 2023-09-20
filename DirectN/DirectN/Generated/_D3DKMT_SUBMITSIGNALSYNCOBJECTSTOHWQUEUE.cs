// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SUBMITSIGNALSYNCOBJECTSTOHWQUEUE
    {
        public _D3DDDICB_SIGNALFLAGS Flags;
        public uint BroadcastHwQueueCount;
        public IntPtr BroadcastHwQueueArray;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
    }
}
