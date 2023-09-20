// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITWAITFORSYNCOBJECTSTOHWQUEUE
    {
        public IntPtr hHwQueue;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
    }
}
