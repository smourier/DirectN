// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_VALIDATESUBMITCOMMAND
    {
        public ulong Commands;
        public uint CommandLength;
        public _DXGK_VALIDATESUBMITCOMMANDFLAGS Flags;
        public uint ContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] Context;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint UmdPrivateDataSize;
        public ulong HwQueueProgressFenceId;
    }
}
