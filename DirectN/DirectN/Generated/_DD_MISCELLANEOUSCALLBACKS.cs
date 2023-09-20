// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_GETAVAILDRIVERMEMORY = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_MISCELLANEOUSCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr GetAvailDriverMemory;
    }
}
