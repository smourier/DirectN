// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_SIGNALSYNCHRONIZATIONOBJECTFROMCPU
    {
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
    }
}
