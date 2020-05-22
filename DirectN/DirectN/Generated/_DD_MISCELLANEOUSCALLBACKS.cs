// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(392,9)
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
