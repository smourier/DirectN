// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICB_WAITFORSYNCHRONIZATIONOBJECT2
    {
        public IntPtr hContext;
        public uint ObjectCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ObjectHandleArray;
        public ulong FenceValue;
    }
}
